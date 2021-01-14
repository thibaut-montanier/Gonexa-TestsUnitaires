using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary {
    class CodeMetrics {
        private bool maVariable;
        public void MaMethode() {
            int i;
            List<string> mesList = new List<string>();
            foreach (var v in mesList) {
                if (maVariable) {
                    i = 1;
                } else {
                    i = 2;
                }
            }
            
        }

        public void MaMethode2() {
            int i = 1;
            
            i++;
            i++;
            i++;
            i++;
            i++;
            i++;
            i++;
        }
    }
}
