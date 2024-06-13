﻿namespace Hospital.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber {  get; set; } 
        public string Type {  get; set; }
        public string Status {  get; set; }
        public int HospitalID {  get; set; }

        public Hospital Hospital { get; set; }  

    }
}