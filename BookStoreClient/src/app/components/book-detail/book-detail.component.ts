import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookModel } from 'src/app/models/book.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { ErrorService } from 'src/app/services/error.service';
import { AuthService } from 'src/app/services/auth.service';
import { ShoppingCartComponent } from '../shopping-cart/shopping-cart.component';
import { TranslateService } from '@ngx-translate/core';
import { SwalService } from 'src/app/services/swal.service';
import { AddShoppingCartModel } from 'src/app/models/add-shopping-cart.model';
import { ShoppingCartService } from 'src/app/services/shopping-cart.service';

@Component({
  selector: 'app-book-detail',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './book-detail.component.html',
  styleUrl: './book-detail.component.css'
})
export class BookDetailComponent {
  book: BookModel = new BookModel();

  constructor(
    private http: HttpClient,
    private activated: ActivatedRoute,
    private error: ErrorService,
    private auth: AuthService,
    private shopping: ShoppingCartService,
    private translate: TranslateService,
    private swal: SwalService
  ){
    this.activated.params.subscribe(res=> {
      this.http.get<BookModel[]>('https://localhost:7082/api/Books/GetById/' + res["value"]).subscribe({
        next: (res: any) => {
          this.book = res;
        },
        error: (err: HttpErrorResponse) => {
          this.error.errorHandler(err);
        }
      });
    })  
  }

  addShoppingCart() {
    if (localStorage.getItem("response")) {
      const data: AddShoppingCartModel = new AddShoppingCartModel();
      data.bookId = this.book.id;
      data.price = this.book.price;
      data.quantity = 1;
      this.auth.isAuthentication();
      data.userId = this.auth.userId;

      this.http.post("https://localhost:7289/api/ShoppingCarts/Add", data).subscribe({
        next: (res: any) => {
          this.shopping.getAllShoppingCarts();
          this.translate.get("addBookInShoppingCartIsSuccessful").subscribe((res:any) => {
            this.swal.callToast(res);
          });
        },
        error: (err: HttpErrorResponse) => {
          this.error.errorHandler(err);
        }
      });
    }
    else {
      if (this.book.quantity < 1) {
        this.translate.get("bookQuantityIsNotEnough").subscribe((res:any) => {
          this.swal.callToast(res, "error");
        })
      }
      else {
        const checkBookIsAlreadyExists = this.shopping.shoppingCarts.filter(p => p.id == this.book.id)[0];

        //Aynı kitap sepette mevcutsa
        if (checkBookIsAlreadyExists !== undefined) {
          this.shopping.shoppingCarts.filter(p => p.id == this.book.id)[0].quantity += 1
        }
        //daha önceden hiç eklenmediyse 1 adet eklenir
        else {
          const newBook = { ...this.book };
          newBook.quantity = 1
          this.shopping.shoppingCarts.push(newBook);
        }

        this.shopping.calcTotal();
        localStorage.setItem("shoppingCarts", JSON.stringify(this.shopping.shoppingCarts));
        this.translate.get("addBookInShoppingCartIsSuccessful").subscribe((res:any) => {
          this.swal.callToast(res);
        });
      }
    }
  }
}
