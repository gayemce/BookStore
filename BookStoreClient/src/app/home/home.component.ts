import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { RequestModel } from '../models/request.model';
import { BookModel } from '../models/book.model';
import { ShoppingCartService } from '../services/shopping-cart.service';
import { SwalService } from '../services/swal.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  books: BookModel[] = []; //book.model.ts oluşturuldu
  categories: any = [];
  pageNumbers: number[] = [];
  request: RequestModel = new RequestModel();
  searchCategory: string = "";
  newData: any[] = [];

  constructor(
    private http: HttpClient,
    private shopping: ShoppingCartService,
    private swal: SwalService,
    private translate: TranslateService
  ) {
    this.getCategories();
  }

  addShoppingCart(book: BookModel) {
    this.shopping.shoppingCarts.push(book); //kaydedildi.
    localStorage.setItem("shoppingCarts", JSON.stringify(this.shopping.shoppingCarts)); //localStrorage yazdırıldı.
    this.shopping.count++;
    this.translate.get("addBookInShoppingCartIsSuccessful").subscribe(res => {
      this.swal.callToast(res);
    })
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
    this.http
      .post<BookModel[]>(`https://localhost:7289/api/Books/GetAll/`, this.request)
      .subscribe(res => {
        this.books = res;
      })
  }

  getCategories() {
    this.http.get(`https://localhost:7289/api/Categories/GetAll`)
      .subscribe(res => {
        this.categories = res;
        this.getAll();
      });
  }

}
