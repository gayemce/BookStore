import { BookModel } from "./book.model";

export class PaymentModel {
    userId: number | null = 0;
    books: BookModel[] = []
    buyer: BuyerModel = new BuyerModel();
    shippingAddress: AddressModel = new AddressModel();
    billingAddress: AddressModel = new AddressModel();
    paymentCard: PaymentCardModel = new PaymentCardModel();
}

export class BuyerModel {
    id: string = "";
    name: string = "Gaye";
    surname: string = "Tekin";
    identityNumber: string = "12345678901";
    email: string = "gayemce4@gmail.com";
    gsmNumber: string = "5416022536";
    registrationDate: string = "";
    lastLoginDate: string = "";
    registrationAddress: string = "";
    city: string = "";
    country: string = "";
    zipCode: string = "";
    ip: string = "";
}

export class AddressModel {
    description: string = "Kırıkkale";
    zipCode: string = "71000";
    contactName: string = "Gaye Tekin";
    city: string = "Kırıkkale";
    country: string = "Türkiye";
}

export class PaymentCardModel {
    cardHolderName: string = "Gaye Tekn";
    cardNumber: string = "";
    expireYear: string = "";
    expireMonth: string = "";
    cvc: string = "377";
}