using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankzaken {
    internal class AccountNumbers {

        int accountNumber = -1;
                
        public AccountNumbers() {
            
        }

        public int getAccountNumber() {
            accountNumber++;
            return accountNumber;
        }
    }
}
