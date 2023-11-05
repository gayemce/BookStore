﻿using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.ValueObjects;
using Iyzipay.Model.V2.Subscription;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreServer.WebApi.Models;

public sealed class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; } //16 hane ve unique olacak GY20230000000001

    [ForeignKey("Book")]
    public int BookId { get; set; }
    public Book Book { get; set; }

    public int Quantity { get; set; }
    public Money Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentType { get; set; }
    public string PaymentNumber { get; set; }

    public static string GetNewOrderNumber()
    {
        string initialLetter = "GY"; //seri numarası
        string year = DateTime.Now.Year.ToString();
        string newOrderNumber = initialLetter + year;

        AppDbContext context = new();
        var lastOrder = context.Orders.OrderByDescending(o => o.Id).FirstOrDefault();
        string currentOrderNumber = lastOrder?.OrderNumber; //son siparişin, sipariş numarası

        if (currentOrderNumber != null) //son sipariş varsa
        {
            string currentYear = currentOrderNumber.Substring(2, 4);
            int startIndex = (currentYear == year) ? 6 : 0; //for substring
            GenerateUniqueOrderNumber(context, ref newOrderNumber, currentOrderNumber.Substring(startIndex)); //ref: referans
        }
        else
        {
            newOrderNumber += "0000000001"; //ilk sipariş
        }

        return newOrderNumber;
    }

    private static void GenerateUniqueOrderNumber(AppDbContext context, ref string newOrderNumber, string currentOrderNumStr)
    {
        int currentOrderNumberInt = int.TryParse(currentOrderNumStr, out var num) ? num : 0;
        bool isOrderNumberUnique = false;

        while (!isOrderNumberUnique)
        {
            currentOrderNumberInt++;
            newOrderNumber += currentOrderNumberInt.ToString("D10");
            string checkOrderNumber = newOrderNumber;
            var order = context.Orders.FirstOrDefault(o => o.OrderNumber == checkOrderNumber);
            if (order == null)
            {
                isOrderNumberUnique = true;
            }
        }
    }

}