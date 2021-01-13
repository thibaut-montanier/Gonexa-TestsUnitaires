using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary {
    public class DisposableObject : IDisposable {


        public void Close() {

        }
        protected virtual void Dispose(bool full) {
            if (full)
                this.Close();
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
    }
}
