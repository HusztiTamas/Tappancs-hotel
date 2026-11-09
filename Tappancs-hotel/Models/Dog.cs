using System;
using System.Collections.Generic;
using System.Text;

namespace Tappancs_hotel.Models
{
    public class Dog : Pet
    {
        public Dog(string name) : base(name, "Kutya", "🐶")
        {

        }
        public override string Speak()
        {
            return "Vau-vau!";
        }
        public override string Play()
        {
            ChangeStats(-14, 30, -24);
            return $"{Name} boldogan labdázott! + 30 jókedv";
        }
    }
}
