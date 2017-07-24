using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace SampleWebBlog.Models
{
    public class Mahasiswa
    {
        [Required(ErrorMessage ="Nim harus diisi")]
        public string Nim { get; set; }

        [Required(ErrorMessage ="Nama harus diisi")]
        public string Nama { get; set; }

        [Required(ErrorMessage ="Email harus diisi")]
        [EmailAddress(ErrorMessage ="Email format harus sesuai")]
        public string Email { get; set; }

        [Range(0,4)]
        public double IPK { get; set; }
    }
}