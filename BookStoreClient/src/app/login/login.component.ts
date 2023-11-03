import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ShoppingCartService } from '../services/shopping-cart.service';
import { SetShoppingCartsModel } from '../models/shopping-carts.model';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  constructor(
    private http: HttpClient,
    private router: Router,
    private auth: AuthService,
    private shoppingCart: ShoppingCartService
  ) {

  }

  signIn(form: NgForm) {
    if (form.valid) {
      this.http.post(
        "https://localhost:7289/api/Auth/Login",
        {
          usernameOrEmail: form.controls["usernameOrEmail"].value,
          password: form.controls["password"].value
        })
        .subscribe((res: any) => {
          //token işlenecek
          localStorage.setItem("response", JSON.stringify(res));
          this.auth.isAuthentication();
          
          debugger
          const request: SetShoppingCartsModel[] = [];

          //sepette ürün varsa 
          if(this.shoppingCart.shoppingCarts.length > 0){
            for(let s of this.shoppingCart.shoppingCarts){
              const cart = new SetShoppingCartsModel();
                cart.bookId = s.id;
                cart.userId = this.auth.userId;
                cart.price = s.price;
                cart.quantity = 1;

              request.push(cart);
            }
  
            this.http.post("https://localhost:7289/api/ShoppingCarts/SetShoppingCartsFromLocalStorage", request).subscribe(res => {
              localStorage.removeItem("shoppingCarts");
              this.shoppingCart.checkLocalStorageForShoppingCarts();
            })
          }
          
          
          this.router.navigateByUrl("/");
        })
    }
  }
}
