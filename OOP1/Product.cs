using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{ //Snippet = hazır kodlar demek
    class Product           // Entity = varlık demek
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }



        // CRUD = eklemek, okumak, güncellemek, silmek operasyonları denir
    }

}
