﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLibrary.Entity
{
    public partial class Message
    {
        public long Id { get; set; }
        public string MessageText { get; set; }
        public long? SenderUserId { get; set; }
        public long? RecipientUserId { get; set; }
        public DateTime? SendDate { get; set; }
        public byte? Status { get; set; }

        public virtual User RecipientUser { get; set; }
        public virtual User SenderUser { get; set; }
    }
}