using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public partial class CaptchaNoCompletadoExeption: Exception
    {
        public CaptchaNoCompletadoExeption() : base("captcha no completado")
        {

        }
    }
}
