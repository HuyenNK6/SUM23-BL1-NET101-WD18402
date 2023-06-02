﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_13_QLGV
{
    internal class GiaoVien
    {
        private int id;
        private string ten;
        private double soGioDay;
        public GiaoVien()
        {

        }

        public GiaoVien(int id, string ten, double soGioDay)
        {
            this.id = id;
            this.ten = ten;
            this.soGioDay = soGioDay;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public double SoGioDay { get => soGioDay; set => soGioDay = value; }
    
        public virtual void InThongTin()
        {
            Console.WriteLine($"{id}| {ten}| {soGioDay}");
        }
    }
}
