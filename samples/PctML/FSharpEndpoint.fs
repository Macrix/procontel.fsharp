namespace PctML
open ProconTel.Sdk.Attributes
open ProconTel.Sdk.Services
open System.Threading.Tasks

  [<EndpointMetadata(Name = "FSharp", UseCustomSubscriberConfiguration = true, SupportedRoles = SupportedRoles.Both)>]
  type FSharpEndpoint(logger: ILogger) = 
    interface ProconTel.Sdk.Builders.IEndpointLifeTimeCycle with
      member this.InitializeAsync() = 
        logger.Information "F# start"
        Task.CompletedTask
      member this.TerminateAsync() = 
        logger.Information "F# done"
        Task.CompletedTask
