import { BookModel, Money } from "./book.model";
import { OrderStatuesModel } from "./order-status-model";

export class OrderModel {
    id: number = 0;
    orderNumber: string = "";
    book: BookModel = new BookModel();
    quantity: number = 0;
    price: Money = new Money();
    createdAt: string = "";
    paymentDate: string = "";
    paymentType: string = "";
    paymentNumber: string = "";
    orderStatuses: OrderStatuesModel[] = [];
    comment: string = "";
    raiting: number = 0;
  }