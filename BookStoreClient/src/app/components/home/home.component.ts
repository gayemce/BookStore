import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Component } from '@angular/core';
import { RequestModel } from '../../models/request.model';
import { BookModel } from '../../models/book.model';
import { ShoppingCartService } from '../../services/shopping-cart.service';
import { SwalService } from '../../services/swal.service';
import { TranslateService, TranslateModule } from '@ngx-translate/core';
import { AddShoppingCartModel } from 'src/app/models/add-shopping-cart.model';
import { AuthService } from 'src/app/services/auth.service';
import { ErrorService } from 'src/app/services/error.service';
import { PopupService } from 'src/app/services/popup.service';
import { CategoryPipe } from '../../pipes/category.pipe';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { IconControlDirective } from '../../directives/icon-control.directive';
import { FormsModule } from '@angular/forms';
import { NgIf, NgFor, NgClass, CurrencyPipe } from '@angular/common';


@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css'],
    standalone: true,
    imports: [NgIf, FormsModule, NgFor, IconControlDirective, NgClass, InfiniteScrollModule, CurrencyPipe, TranslateModule, CategoryPipe]
})
export class HomeComponent {
  books: BookModel[] = []; //book.model.ts oluşturuldu
  categories: any = [];
  pageNumbers: number[] = [];
  request: RequestModel = new RequestModel();
  searchCategory: string = "";
  newData: any[] = [];
  loaderDatas = [1, 2, 3, 4, 5, 6];
  isLoading: boolean = true;

  constructor(
    private http: HttpClient,
    private shopping: ShoppingCartService,
    private swal: SwalService,
    private translate: TranslateService,
    private error: ErrorService,
    private auth: AuthService,
    private popup: PopupService
  ) {
    //login girişi yapıldığında kullanıcının kaldığı kategoriden devam eder.
    if (localStorage.getItem("request")) {
      const requestString: any = localStorage.getItem("request");
      const requestObj = JSON.parse(requestString);
      this.request = requestObj;
    }
    this.getCategories();
  }

  addShoppingCart(book: BookModel) {
    if (localStorage.getItem("response")) {
      const data: AddShoppingCartModel = new AddShoppingCartModel();
      data.bookId = book.id;
      data.price = book.price;
      data.quantity = 1;
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
      if (book.quantity < 1) {
        this.translate.get("bookQuantityIsNotEnough").subscribe((res:any) => {
          this.swal.callToast(res, "error");
        })
      }
      else {
        const checkBookIsAlreadyExists = this.shopping.shoppingCarts.filter(p => p.id == book.id)[0];

        //Aynı kitap sepette mevcutsa
        if (checkBookIsAlreadyExists !== undefined) {
          this.shopping.shoppingCarts.filter(p => p.id == book.id)[0].quantity += 1
        }
        //daha önceden hiç eklenmediyse 1 adet eklenir
        else {
          const newBook = { ...book };
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


  feedData() {
    this.request.pageSize += 10;
    this.newData = [];
    this.getAll();
  }

  changeCategory(categoryId: number | null = null) {
    this.request.categoryId = categoryId;
    this.request.pageSize = 0; //Kategori değiştiğinde kaydı sıfırlar
    this.feedData();
  }

  getAll() {
    this.isLoading = true;
    this.http
      .post<BookModel[]>(`https://localhost:7289/api/Books/GetAll/`, this.request)
      .subscribe({
        next: (res: any) => {
          this.books = res;
          this.isLoading = false;
          //login girişi yapıldığında kullanıcının kaldığı kategoriden devam eder.
          localStorage.setItem("request", JSON.stringify(this.request));
          this.popup.showDriverPopup();
        },
        error: (err: HttpErrorResponse) => {
          this.error.errorHandler(err);
        }
      })
  }

  getCategories() {
    this.isLoading = true;
    this.http.get(`https://localhost:7289/api/Categories/GetAll`)
      .subscribe({
        next: (res: any) => {
          this.categories = res;
          this.getAll();
          this.isLoading = false;
        },
        error: (err: HttpErrorResponse) => {
          this.error.errorHandler(err);
        }
      });
  }

  leftSlider() {
    const workList:any = document.querySelector(".work-list");
    const slideAmount = 295;  
    workList.scrollLeft -= slideAmount * 1;
    workList.scrollLeft = Math.max(0, workList.scrollLeft);
  }

  rightSlider(){
    const workList:any = document.querySelector(".work-list");
    const slideAmount = 295; 
    const maxScroll = slideAmount * (11) -5;
    workList.scrollLeft += slideAmount * 1;
    workList.scrollLeft = Math.min(maxScroll, workList.scrollLeft);
    
  }

}
