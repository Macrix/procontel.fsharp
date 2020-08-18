namespace PctML
open ProconTel.Sdk.Attributes
open ProconTel.Sdk.Services
open System.Threading.Tasks
open System.Reflection

  [<EndpointMetadata(Name = "FSharp", UseCustomSubscriberConfiguration = true, SupportedRoles = SupportedRoles.Both)>]
  type FSharpEndpoint(logger: ILogger) = 
    interface ProconTel.Sdk.Builders.IEndpointLifeTimeCycle with
      member this.InitializeAsync() = 
        logger.Information("F# start, version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString())
        logger.Information("F# demo")
        Task.CompletedTask
      member this.TerminateAsync() = 
        logger.Information "F# done"
        Task.CompletedTask
