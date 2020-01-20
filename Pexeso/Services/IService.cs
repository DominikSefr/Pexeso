using Pexeso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pexeso.Services
{
    public interface IService
    {
        List<Card> Cards { get; set; }
        List<Image> Imgs { get; set; }
        void Increment();
        void Click(int j);
        void Shuffle();
        void Restart();
        bool Check();
        void New_Game();

    }
}
