/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.28
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp.Model
{
    /// <summary>
    /// The user type of the User.
    /// </summary>
    /// <value>The user type of the User.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEUserType
    {
        /// <summary>
        /// Enum AgentBroker for value: AgentBroker
        /// </summary>
        [EnumMember(Value = "AgentBroker")]
        AgentBroker = 1,

        /// <summary>
        /// Enum Assistant for value: Assistant
        /// </summary>
        [EnumMember(Value = "Assistant")]
        Assistant = 2,

        /// <summary>
        /// Enum Attendance for value: Attendance
        /// </summary>
        [EnumMember(Value = "Attendance")]
        Attendance = 3,

        /// <summary>
        /// Enum Customer for value: Customer
        /// </summary>
        [EnumMember(Value = "Customer")]
        Customer = 4,

        /// <summary>
        /// Enum Employee for value: Employee
        /// </summary>
        [EnumMember(Value = "Employee")]
        Employee = 5,

        /// <summary>
        /// Enum Ezcom for value: Ezcom
        /// </summary>
        [EnumMember(Value = "Ezcom")]
        Ezcom = 6,

        /// <summary>
        /// Enum EzsignSigner for value: EzsignSigner
        /// </summary>
        [EnumMember(Value = "EzsignSigner")]
        EzsignSigner = 7,

        /// <summary>
        /// Enum EzsignUser for value: EzsignUser
        /// </summary>
        [EnumMember(Value = "EzsignUser")]
        EzsignUser = 8,

        /// <summary>
        /// Enum FranchiseCustomerServer for value: FranchiseCustomerServer
        /// </summary>
        [EnumMember(Value = "FranchiseCustomerServer")]
        FranchiseCustomerServer = 9,

        /// <summary>
        /// Enum Normal for value: Normal
        /// </summary>
        [EnumMember(Value = "Normal")]
        Normal = 10,

        /// <summary>
        /// Enum RewardAdministration for value: RewardAdministration
        /// </summary>
        [EnumMember(Value = "RewardAdministration")]
        RewardAdministration = 11,

        /// <summary>
        /// Enum RewardMember for value: RewardMember
        /// </summary>
        [EnumMember(Value = "RewardMember")]
        RewardMember = 12,

        /// <summary>
        /// Enum RewardRepresentative for value: RewardRepresentative
        /// </summary>
        [EnumMember(Value = "RewardRepresentative")]
        RewardRepresentative = 13,

        /// <summary>
        /// Enum RewardCustomer for value: RewardCustomer
        /// </summary>
        [EnumMember(Value = "RewardCustomer")]
        RewardCustomer = 14,

        /// <summary>
        /// Enum RewardDistributorServer for value: RewardDistributorServer
        /// </summary>
        [EnumMember(Value = "RewardDistributorServer")]
        RewardDistributorServer = 15,

        /// <summary>
        /// Enum Supplier for value: Supplier
        /// </summary>
        [EnumMember(Value = "Supplier")]
        Supplier = 16,

        /// <summary>
        /// Enum VetrxCustomer for value: VetrxCustomer
        /// </summary>
        [EnumMember(Value = "VetrxCustomer")]
        VetrxCustomer = 17,

        /// <summary>
        /// Enum Vetrxcustomergroup for value: Vetrxcustomergroup
        /// </summary>
        [EnumMember(Value = "Vetrxcustomergroup")]
        Vetrxcustomergroup = 18,

        /// <summary>
        /// Enum VetrxCustomerServer for value: VetrxCustomerServer
        /// </summary>
        [EnumMember(Value = "VetrxCustomerServer")]
        VetrxCustomerServer = 19,

        /// <summary>
        /// Enum VetrxManufacturer for value: VetrxManufacturer
        /// </summary>
        [EnumMember(Value = "VetrxManufacturer")]
        VetrxManufacturer = 20,

        /// <summary>
        /// Enum VetrxVendor for value: VetrxVendor
        /// </summary>
        [EnumMember(Value = "VetrxVendor")]
        VetrxVendor = 21

    }

}
