/* 
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * OpenAPI spec version: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// AnonymizerResult
    /// </summary>
    [DataContract]
        public partial class AnonymizerResult :  IEquatable<AnonymizerResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizerResult" /> class.
        /// </summary>
        /// <param name="start">Where the anonymized PII starts (required).</param>
        /// <param name="end">Where the anonymized PII ends (required).</param>
        /// <param name="entityType">entityType (required).</param>
        public AnonymizerResult(int? start = default(int?), int? end = default(int?), string entityType = default(string))
        {
            // to ensure "start" is required (not null)
            if (start == null)
            {
                throw new InvalidDataException("start is a required property for AnonymizerResult and cannot be null");
            }
            else
            {
                this.Start = start;
            }
            // to ensure "end" is required (not null)
            if (end == null)
            {
                throw new InvalidDataException("end is a required property for AnonymizerResult and cannot be null");
            }
            else
            {
                this.End = end;
            }
            // to ensure "entityType" is required (not null)
            if (entityType == null)
            {
                throw new InvalidDataException("entityType is a required property for AnonymizerResult and cannot be null");
            }
            else
            {
                this.EntityType = entityType;
            }
        }
        
        /// <summary>
        /// Where the anonymized PII starts
        /// </summary>
        /// <value>Where the anonymized PII starts</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public int? Start { get; set; }

        /// <summary>
        /// Where the anonymized PII ends
        /// </summary>
        /// <value>Where the anonymized PII ends</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public int? End { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entity_type", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnonymizerResult {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnonymizerResult);
        }

        /// <summary>
        /// Returns true if AnonymizerResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AnonymizerResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnonymizerResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
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
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
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
            yield break;
        }
    }
}