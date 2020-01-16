using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Services
{

    //creata da Andrea T. per incorporare le risorse locali presenti in android.assets nei file html tramite il baseUrl
    public interface IBaseUrl
    {
        string Get();
    }
}
