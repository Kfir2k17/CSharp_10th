using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_9___Sukot
{
    internal class ZoomStudent
    {
        private string kind;
        private bool mice;
        private bool cam;

        public ZoomStudent(bool mice, bool cam)
        {
            this.mice = mice;
            this.cam = cam;

            if (mice && cam)
                this.kind = "etrog";

            if (!mice && cam)
                this.kind = "lulav";

            if (mice && !cam)
                this.kind = "hadas";

            if (!mice && !cam)
                this.kind = "arava";
        }

        public bool GetCamera()
        {
            return cam;
        }

        public bool GetMicrophone()
        {
            return mice;
        }

        public void ChangeCam()
        {
            if (cam)
                cam = false;

            if (!cam)
                cam = true;
        }

        public void ChangeMice()
        {
            if (mice)
                mice = false;

            if (!mice)
                mice = true;
        }

        public override string ToString()
        {
            return "The kind of the student: " + kind;
        }

        public string GetKind()
        {
            return kind;
        }
    }
}
