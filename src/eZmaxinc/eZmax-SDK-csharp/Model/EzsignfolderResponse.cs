/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.33
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
    /// An Ezsignfolder Object
    /// </summary>
    [DataContract]
    public partial class EzsignfolderResponse :  IEquatable<EzsignfolderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderResponse" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here. (required).</param>
        /// <param name="fkiEzsigntsarequirementID">The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| (required).</param>
        /// <param name="sEzsignfolderDescription">The description of the Ezsign Folder (required).</param>
        /// <param name="tEzsignfolderNote">Somes extra notes about the eZsign Folder (required).</param>
        /// <param name="eEzsignfolderSendreminderfrequency">eEzsignfolderSendreminderfrequency (required).</param>
        /// <param name="pkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="dtEzsignfolderSentdate">The date and time at which the Ezsign folder was sent the last time. (required).</param>
        /// <param name="eEzsignfolderStep">eEzsignfolderStep (required).</param>
        /// <param name="dtEzsignfolderClose">The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely. (required).</param>
        /// <param name="objAudit">objAudit (required).</param>
        public EzsignfolderResponse(int fkiEzsignfoldertypeID = default(int), int fkiEzsigntsarequirementID = default(int), string sEzsignfolderDescription = default(string), string tEzsignfolderNote = default(string), FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency = default(FieldEEzsignfolderSendreminderfrequency), int pkiEzsignfolderID = default(int), string dtEzsignfolderSentdate = default(string), FieldEEzsignfolderStep eEzsignfolderStep = default(FieldEEzsignfolderStep), string dtEzsignfolderClose = default(string), CommonAudit objAudit = default(CommonAudit))
        {
            // to ensure "fkiEzsignfoldertypeID" is required (not null)
            if (fkiEzsignfoldertypeID == null)
            {
                throw new InvalidDataException("fkiEzsignfoldertypeID is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.fkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            }

            // to ensure "fkiEzsigntsarequirementID" is required (not null)
            if (fkiEzsigntsarequirementID == null)
            {
                throw new InvalidDataException("fkiEzsigntsarequirementID is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.fkiEzsigntsarequirementID = fkiEzsigntsarequirementID;
            }

            // to ensure "sEzsignfolderDescription" is required (not null)
            if (sEzsignfolderDescription == null)
            {
                throw new InvalidDataException("sEzsignfolderDescription is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.sEzsignfolderDescription = sEzsignfolderDescription;
            }

            // to ensure "tEzsignfolderNote" is required (not null)
            if (tEzsignfolderNote == null)
            {
                throw new InvalidDataException("tEzsignfolderNote is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.tEzsignfolderNote = tEzsignfolderNote;
            }

            // to ensure "eEzsignfolderSendreminderfrequency" is required (not null)
            if (eEzsignfolderSendreminderfrequency == null)
            {
                throw new InvalidDataException("eEzsignfolderSendreminderfrequency is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.eEzsignfolderSendreminderfrequency = eEzsignfolderSendreminderfrequency;
            }

            // to ensure "pkiEzsignfolderID" is required (not null)
            if (pkiEzsignfolderID == null)
            {
                throw new InvalidDataException("pkiEzsignfolderID is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.pkiEzsignfolderID = pkiEzsignfolderID;
            }

            // to ensure "dtEzsignfolderSentdate" is required (not null)
            if (dtEzsignfolderSentdate == null)
            {
                throw new InvalidDataException("dtEzsignfolderSentdate is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.dtEzsignfolderSentdate = dtEzsignfolderSentdate;
            }

            // to ensure "eEzsignfolderStep" is required (not null)
            if (eEzsignfolderStep == null)
            {
                throw new InvalidDataException("eEzsignfolderStep is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.eEzsignfolderStep = eEzsignfolderStep;
            }

            // to ensure "dtEzsignfolderClose" is required (not null)
            if (dtEzsignfolderClose == null)
            {
                throw new InvalidDataException("dtEzsignfolderClose is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.dtEzsignfolderClose = dtEzsignfolderClose;
            }

            // to ensure "objAudit" is required (not null)
            if (objAudit == null)
            {
                throw new InvalidDataException("objAudit is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.objAudit = objAudit;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.</value>
        [DataMember(Name="fkiEzsignfoldertypeID", EmitDefaultValue=true)]
        public int fkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|
        /// </summary>
        /// <value>The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|</value>
        [DataMember(Name="fkiEzsigntsarequirementID", EmitDefaultValue=true)]
        public int fkiEzsigntsarequirementID { get; set; }

        /// <summary>
        /// The description of the Ezsign Folder
        /// </summary>
        /// <value>The description of the Ezsign Folder</value>
        [DataMember(Name="sEzsignfolderDescription", EmitDefaultValue=true)]
        public string sEzsignfolderDescription { get; set; }

        /// <summary>
        /// Somes extra notes about the eZsign Folder
        /// </summary>
        /// <value>Somes extra notes about the eZsign Folder</value>
        [DataMember(Name="tEzsignfolderNote", EmitDefaultValue=true)]
        public string tEzsignfolderNote { get; set; }

        /// <summary>
        /// Gets or Sets eEzsignfolderSendreminderfrequency
        /// </summary>
        [DataMember(Name="eEzsignfolderSendreminderfrequency", EmitDefaultValue=true)]
        public FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        [DataMember(Name="pkiEzsignfolderID", EmitDefaultValue=true)]
        public int pkiEzsignfolderID { get; set; }

        /// <summary>
        /// The date and time at which the Ezsign folder was sent the last time.
        /// </summary>
        /// <value>The date and time at which the Ezsign folder was sent the last time.</value>
        [DataMember(Name="dtEzsignfolderSentdate", EmitDefaultValue=true)]
        public string dtEzsignfolderSentdate { get; set; }

        /// <summary>
        /// Gets or Sets eEzsignfolderStep
        /// </summary>
        [DataMember(Name="eEzsignfolderStep", EmitDefaultValue=true)]
        public FieldEEzsignfolderStep eEzsignfolderStep { get; set; }

        /// <summary>
        /// The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely.
        /// </summary>
        /// <value>The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely.</value>
        [DataMember(Name="dtEzsignfolderClose", EmitDefaultValue=true)]
        public string dtEzsignfolderClose { get; set; }

        /// <summary>
        /// Gets or Sets objAudit
        /// </summary>
        [DataMember(Name="objAudit", EmitDefaultValue=true)]
        public CommonAudit objAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderResponse {\n");
            sb.Append("  fkiEzsignfoldertypeID: ").Append(fkiEzsignfoldertypeID).Append("\n");
            sb.Append("  fkiEzsigntsarequirementID: ").Append(fkiEzsigntsarequirementID).Append("\n");
            sb.Append("  sEzsignfolderDescription: ").Append(sEzsignfolderDescription).Append("\n");
            sb.Append("  tEzsignfolderNote: ").Append(tEzsignfolderNote).Append("\n");
            sb.Append("  eEzsignfolderSendreminderfrequency: ").Append(eEzsignfolderSendreminderfrequency).Append("\n");
            sb.Append("  pkiEzsignfolderID: ").Append(pkiEzsignfolderID).Append("\n");
            sb.Append("  dtEzsignfolderSentdate: ").Append(dtEzsignfolderSentdate).Append("\n");
            sb.Append("  eEzsignfolderStep: ").Append(eEzsignfolderStep).Append("\n");
            sb.Append("  dtEzsignfolderClose: ").Append(dtEzsignfolderClose).Append("\n");
            sb.Append("  objAudit: ").Append(objAudit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EzsignfolderResponse);
        }

        /// <summary>
        /// Returns true if EzsignfolderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiEzsignfoldertypeID == input.fkiEzsignfoldertypeID ||
                    (this.fkiEzsignfoldertypeID != null &&
                    this.fkiEzsignfoldertypeID.Equals(input.fkiEzsignfoldertypeID))
                ) && 
                (
                    this.fkiEzsigntsarequirementID == input.fkiEzsigntsarequirementID ||
                    (this.fkiEzsigntsarequirementID != null &&
                    this.fkiEzsigntsarequirementID.Equals(input.fkiEzsigntsarequirementID))
                ) && 
                (
                    this.sEzsignfolderDescription == input.sEzsignfolderDescription ||
                    (this.sEzsignfolderDescription != null &&
                    this.sEzsignfolderDescription.Equals(input.sEzsignfolderDescription))
                ) && 
                (
                    this.tEzsignfolderNote == input.tEzsignfolderNote ||
                    (this.tEzsignfolderNote != null &&
                    this.tEzsignfolderNote.Equals(input.tEzsignfolderNote))
                ) && 
                (
                    this.eEzsignfolderSendreminderfrequency == input.eEzsignfolderSendreminderfrequency ||
                    (this.eEzsignfolderSendreminderfrequency != null &&
                    this.eEzsignfolderSendreminderfrequency.Equals(input.eEzsignfolderSendreminderfrequency))
                ) && 
                (
                    this.pkiEzsignfolderID == input.pkiEzsignfolderID ||
                    (this.pkiEzsignfolderID != null &&
                    this.pkiEzsignfolderID.Equals(input.pkiEzsignfolderID))
                ) && 
                (
                    this.dtEzsignfolderSentdate == input.dtEzsignfolderSentdate ||
                    (this.dtEzsignfolderSentdate != null &&
                    this.dtEzsignfolderSentdate.Equals(input.dtEzsignfolderSentdate))
                ) && 
                (
                    this.eEzsignfolderStep == input.eEzsignfolderStep ||
                    (this.eEzsignfolderStep != null &&
                    this.eEzsignfolderStep.Equals(input.eEzsignfolderStep))
                ) && 
                (
                    this.dtEzsignfolderClose == input.dtEzsignfolderClose ||
                    (this.dtEzsignfolderClose != null &&
                    this.dtEzsignfolderClose.Equals(input.dtEzsignfolderClose))
                ) && 
                (
                    this.objAudit == input.objAudit ||
                    (this.objAudit != null &&
                    this.objAudit.Equals(input.objAudit))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.fkiEzsignfoldertypeID != null)
                    hashCode = hashCode * 59 + this.fkiEzsignfoldertypeID.GetHashCode();
                if (this.fkiEzsigntsarequirementID != null)
                    hashCode = hashCode * 59 + this.fkiEzsigntsarequirementID.GetHashCode();
                if (this.sEzsignfolderDescription != null)
                    hashCode = hashCode * 59 + this.sEzsignfolderDescription.GetHashCode();
                if (this.tEzsignfolderNote != null)
                    hashCode = hashCode * 59 + this.tEzsignfolderNote.GetHashCode();
                if (this.eEzsignfolderSendreminderfrequency != null)
                    hashCode = hashCode * 59 + this.eEzsignfolderSendreminderfrequency.GetHashCode();
                if (this.pkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.pkiEzsignfolderID.GetHashCode();
                if (this.dtEzsignfolderSentdate != null)
                    hashCode = hashCode * 59 + this.dtEzsignfolderSentdate.GetHashCode();
                if (this.eEzsignfolderStep != null)
                    hashCode = hashCode * 59 + this.eEzsignfolderStep.GetHashCode();
                if (this.dtEzsignfolderClose != null)
                    hashCode = hashCode * 59 + this.dtEzsignfolderClose.GetHashCode();
                if (this.objAudit != null)
                    hashCode = hashCode * 59 + this.objAudit.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

 
            // fkiEzsigntsarequirementID (int) maximum
            if(this.fkiEzsigntsarequirementID > (int)3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiEzsigntsarequirementID, must be a value less than or equal to 3.", new [] { "fkiEzsigntsarequirementID" });
            }

            // fkiEzsigntsarequirementID (int) minimum
            if(this.fkiEzsigntsarequirementID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiEzsigntsarequirementID, must be a value greater than or equal to 1.", new [] { "fkiEzsigntsarequirementID" });
            }

            yield break;
        }
    }

}
