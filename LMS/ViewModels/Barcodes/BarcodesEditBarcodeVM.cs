﻿using System;
using System.Web.WebPages.Html;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using LMS.DataAccess.Entities;

namespace LMS.ViewModels.Barcodes
{
    public class BarcodesEditBarcodeVM
    {
        public int ID { get; set; }

        [DisplayName("Barcode")]
        [Required(ErrorMessage = "* barcode required")]
        public int BarcodeNumber { get; set; }      
        
        public virtual int BookID { get; set; }               
    }
}