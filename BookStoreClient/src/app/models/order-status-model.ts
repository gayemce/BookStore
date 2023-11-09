import { OrderStatusEnum } from "./order-status-enum";

export class OrderStatuesModel {
    id: number = 0;
    orderNumber: string = ""
    status: OrderStatusEnum = OrderStatusEnum.AwatingApproval;
    statusDate: string = "";
  }