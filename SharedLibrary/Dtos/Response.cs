using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class Response<T> where T : class
    {
        public T Data { get; private set; }
        public int StatusCode { get; private set; } //Client başka bir yerde kullanacağı zaman lazım olabilir.Private vermemizin sebebi bu propertyi burada set edeceğiz.Dışarıdan set edilmeyecek.

        [JsonIgnore] //Jsondataya dönüştürüldüğünde bu propertyi yok edilecek.
        public  bool IsSuccessful { get;private set; } //Kendi apilerimde başarılı olup olmadığına bakmak için yapıyorum.
        public ErrorDto Error { get;private set; }

        public static Response<T> Success(T data, int statusCode) //istek başarılı olduğu durumda
        {
            return new Response<T> { Data = data, StatusCode = statusCode ,IsSuccessful=true};
        }

        //static kullanmamızın nedeni her seferinde nesne örneği üzerinden erişmeyelim diye.
        public static Response<T> Success(int statusCode) // istek başarılı ama data boş olduğunda,update remove işlemleri gibi
        {
            return new Response<T> { Data = default, StatusCode = statusCode,IsSuccessful=true};

        }

        public static Response<T> Fail(ErrorDto errorDto, int statusCode) //istek başarısız olduğunda
        {
            return new Response<T>
            {
                Error = errorDto,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

        // Tek bir hata döneceği zaman kullanılacak 
        public static Response<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);
            return new Response<T> { Error = errorDto, StatusCode = statusCode ,IsSuccessful=false};
        }
    }
}

