﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp1.Models
{
    public class Credit
    {
        // ID кредита 
        public virtual int CreditId { get; set; }
        // Название 
        [DisplayName("Название кредита")]
        [Required]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит 
        [DisplayName("Срок кредитования")]
        [Required]
        public virtual int Period { get; set; }
        // Максимальная сумма кредита 
        [DisplayName("Максимальная сумма кредита")]
        [Required]
        public virtual int Sum { get; set; }
        // Процентная ставка 
        [DisplayName("Процентная ставка")]
        [Required]
        public virtual int Procent { get; set; }
    }
}
