using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set;  }

        private string _productName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string ProductName { get; set; }

        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState}";

        public override string ToString() => ProductName;

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;

        }
    }
}
