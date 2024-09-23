using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{

    //Apilerde herhangi bir hata oldugunda merkezi error oluşturuyoruz.
    public class ErrorDto
    {
        //Birden fazla hata olabilir.O yüzden liste olarak oluşturuyoruz.
        public List<String> Errors { get; private set; } = new List<string>(); //Private vermemizin sebebi bu propertyi burada set edeceğiz.Dışarıdan set edilmeyecek.
        public bool IsShow { get; private set; }//Gelen hatayı göstermek için oluşturulan property.Kullanıcıya gösterilecek hatalarda true olacak.Yazılımcıya gösterilecek hata da false olacak.

        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            IsShow = isShow;
        }

        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }
    }
}
