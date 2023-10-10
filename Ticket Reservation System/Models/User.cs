﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization; // Add this namespace

public class User
{
    [BsonId]
    [BsonElement("nic")]
    [BsonRepresentation(BsonType.String)]
    [BsonRequired]
    public string Nic { get; set; } = null!;

    [BsonElement("firstName")]
    [BsonRepresentation(BsonType.String)]
    [BsonRequired]
    public string FirstName { get; set; } = null!;

    [BsonElement("lastName")]
    [BsonRepresentation(BsonType.String)]
    [BsonRequired]
    public string LastName { get; set; } = null!;

    [BsonElement("email")]
    [BsonRepresentation(BsonType.String)]
    [BsonRequired]
    public string Email { get; set; } = null!;

    [BsonElement("phone")]
    [BsonRepresentation(BsonType.String)]
    [BsonRequired]
    public string Phone { get; set; } = null!;

    [BsonElement("password")]
    [BsonRepresentation(BsonType.String)]
    [BsonRequired]
    public string Password { get; set; } = null!;

    [BsonElement("status")]
    [JsonIgnore]
    [BsonRepresentation(BsonType.String)]
    public string Status { get; set; } = "active";

}
