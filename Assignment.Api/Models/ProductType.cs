using System.ComponentModel;
using Assignment.Api.Helper;

namespace Assignment.Api.Models
{
    public enum ProductType
    {
        [Description("photoBook")]
        [ProductTypeAttribute(19, 1)]
        photoBook,
        [Description("calendar")]
        [ProductTypeAttribute(10, 1)]
        calendar,
        [Description("canvas")]
        [ProductTypeAttribute(16, 1)]
        canvas,
        [Description("cards")]
        [ProductTypeAttribute(4.7, 1)]
        cards,
        [Description("mug")]
        [ProductTypeAttribute(94, 4)]
        mug
    }


}