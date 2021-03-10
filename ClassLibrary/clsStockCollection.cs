using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    { 
       List<clsStock> mStockList = new List<clsStock>();

        // public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return for private data
                return mStockList;
            }
            set
            {
                // set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return count of the list
                return mStockList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }
        public clsStock ThisStock { get; set; }
    }

    
            
    }
