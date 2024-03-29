﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing,Airbus
    }
    public class Plane
    {
        public Plane() { }
        [Key]

        public int PlaneId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive integer")]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }

        virtual public List<Flight> flights { get; set; }

        [NotMapped]
        public string Information
        {
            get
            {
                return $"PlaneID: {PlaneId}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType}";
            }
        }
        public override string ToString()
        {
            return $"PlaneID: {PlaneId}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType}";
        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;

        }
    }
}
