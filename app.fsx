#r "packages/Suave/lib/net40/Suave.dll"
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"
#r "packages/FSharp.Charting/lib/net40/FSharp.Charting.dll"

open System.Net

let ctxt = FSharp.Data.WorldBankData.GetDataContext()

let data = ctxt.Countries.Algeria.Indicators.``GDP at market prices (current US$)``

open Suave                 // always open suave
//open Suave.Http
open Suave.Successful // for OK-result
//open Suave.Web             // for config

let config =
  { defaultConfig with
     bindings = [HttpBinding.mk HTTP (IPAddress.Parse "0.0.0.0") 8083us]
  }

startWebServer config (OK (sprintf "Hello World! In 2010 Algeria earned %f " data.[2010]))
