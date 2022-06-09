using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FoodWeb.Models;
public class Product
{
    public int Id   { get; set; }

    [Display(Name = "商品名稱")]
    [Required(ErrorMessage = "請輸入名稱")]
    public string Name { get; set; }

    [Display(Name = "說明")]
    [Required(ErrorMessage = "請輸入商品說明")]
    public string Description { get; set; }

    [Display(Name = "價格")]
    [Required(ErrorMessage = "請輸入價格")]
    [Range(1, 10000, ErrorMessage = "價格限制為1~10000元")]
    public double Price { get; set; }

    [Display(Name = "圖片")] [ValidateNever] public string? ImageUrl { get; set; }
}