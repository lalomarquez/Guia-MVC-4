﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuiaMVC4.Models
{
    [MetadataType(typeof(Empleado))]
    public class Empleado
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [ReadOnly(true)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddres { get; set; }

        [ScaffoldColumn(true)]
        [DataType(DataType.Currency)]
        public int? Salry { get; set; }        

        [DataType(DataType.Url)]
        [UIHint("OpenInNewWindow")]
        public string PersonalWebSite { get; set; }

        [DisplayAttribute(Name = "Full Name")]
        public string FullName { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? HireDate { get; set; }

        [DisplayFormat(NullDisplayText = "Gender not specified")]
        public string Gender { get; set; }
    }
}