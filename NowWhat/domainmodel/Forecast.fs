module NowWhat.DomainModel.Forecast

open Thoth.Json.Net

type Project = {
  id: int;
  name: string;
  code: string option
}

let projectDecoder : Decoder<Project> =
    Decode.object (
        fun get -> {
            Project.id = get.Required.Field "id" Decode.int;
            Project.name = get.Required.Field "name" Decode.string;
            Project.code = get.Optional.Field "code" Decode.string;
        }
    )