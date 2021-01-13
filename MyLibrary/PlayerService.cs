using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyLibrary {
    public class PlayerService {
        

        public PlayerService() {


        }

         ~PlayerService() {
            int i = 1;
            i--;
        }
        public virtual List<Player> getAll() {
            throw new NotImplementedException();
        }


        public string LoadDataFromTxt(string filePath) {
            string v;
            using (var sr = new StreamReader(filePath)) {
                v = sr.ReadToEnd();
            }
            return v;
        }
        public virtual string getPlayerLst() {
            return string.Join("\n",
                this.getAll().Select(p=>$"Nom : {p.Name}, prenom : {p.FirstName}"));
        }
    }
}
