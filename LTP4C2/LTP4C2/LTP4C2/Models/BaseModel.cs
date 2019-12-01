using System;

namespace LTP4C2.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            Id = new Guid();
        }
        public Guid   Id{ get; set; }
    }
}
