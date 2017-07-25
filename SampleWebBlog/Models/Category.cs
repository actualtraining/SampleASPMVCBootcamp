using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace SampleWebBlog.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Nama kategori tidak boleh kosong !")]
        public string CategoryName { get; set; }
    }
}