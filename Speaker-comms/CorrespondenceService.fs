﻿module SpeakerComms.CorrespondenceService

open Amazon.DynamoDBv2
open Amazon
open Amazon.DynamoDBv2.DataModel
open Amazon.DynamoDBv2.DocumentModel;
open SpeakerComms.Models
open System

let client = new AmazonDynamoDBClient(RegionEndpoint.EUWest1)
let context = new DynamoDBContext(client)

let getCorrespondence () =                     
    context.Scan<CorrespondenceItem>()