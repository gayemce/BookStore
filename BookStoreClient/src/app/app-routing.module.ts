import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutsComponent } from './components/layouts/layouts.component';
import { HomeComponent } from './components/home/home.component';
import { ShoppingCartComponent } from './components/shopping-cart/shopping-cart.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { MaintenanceComponent } from './components/maintenance/maintenance.component';
import { OrderComponent } from './components/order/order.component';
import { BookDetailComponent } from './components/book-detail/book-detail.component';

const routes: Routes = [
  {
    path: "",
    component: LayoutsComponent,
    children: [
      {
        path: "",
        component: HomeComponent
      },
      {
        path: "shopping-cart",
        component: ShoppingCartComponent
      },
      {
        path: "register",
        component: RegisterComponent
      },
      {
        path: "login",
        component: LoginComponent
      },
      {
        path: "maintenance",
        component: MaintenanceComponent
      },
      {
        path: "orders",
        component: OrderComponent
      },
      {
        path: "book-detail/:value",
        component: BookDetailComponent
      }
      // {
      //   path: "book-detail/:value",
      //   loadComponent:()=> import("./components/book-detail/book-detail.component")
      // }
    ]
  }  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
