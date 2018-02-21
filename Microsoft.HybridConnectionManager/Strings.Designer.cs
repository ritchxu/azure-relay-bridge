﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.HybridConnectionManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.HybridConnectionManager.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Listener&apos;s custom AcceptHandler threw an exception. See Listener logs for details. TrackingId: {0}..
        /// </summary>
        internal static string AcceptHandlerException {
            get {
                return ResourceManager.GetString("AcceptHandlerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensure either all or none of the following arguments are defined: &apos;{0}&apos;..
        /// </summary>
        internal static string ArgumentInvalidCombination {
            get {
                return ResourceManager.GetString("ArgumentInvalidCombination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument is out of range. It should be between {0} and {1}..
        /// </summary>
        internal static string ArgumentOutOfRange {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; cannot exceed {1} characters..
        /// </summary>
        internal static string ArgumentStringTooBig {
            get {
                return ResourceManager.GetString("ArgumentStringTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Buffer allocation failed.
        /// </summary>
        internal static string BufferAllocationFailed {
            get {
                return ResourceManager.GetString("BufferAllocationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contained character &apos;{1}&apos; which is not allowed because it is reserved in the Uri scheme..
        /// </summary>
        internal static string CharacterReservedForUriScheme {
            get {
                return ResourceManager.GetString("CharacterReservedForUriScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existing configuration {0} found..
        /// </summary>
        internal static string ConfigEntryAlreadyExists {
            get {
                return ResourceManager.GetString("ConfigEntryAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} name should be specified as EntityPath in connectionString..
        /// </summary>
        internal static string ConnectionStringMustIncludeEntityPath {
            get {
                return ResourceManager.GetString("ConnectionStringMustIncludeEntityPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connectionString must include either SharedAccessSignature or both SharedAccessKeyName and SharedAccessKey..
        /// </summary>
        internal static string ConnectionStringMustIncludeTokenProviderSettings {
            get {
                return ResourceManager.GetString("ConnectionStringMustIncludeTokenProviderSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} name should not be specified as EntityPath in the connectionString while using this overload. Instead, use the &apos;path&apos; parameter..
        /// </summary>
        internal static string ConnectionStringMustNotIncludeEntityPath {
            get {
                return ResourceManager.GetString("ConnectionStringMustNotIncludeEntityPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for the connection string parameter &apos;{0}&apos; is empty or missing..
        /// </summary>
        internal static string ConnectionStringParameterValueMissing {
            get {
                return ResourceManager.GetString("ConnectionStringParameterValueMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection string contains unknown parameter &apos;{0}&apos;..
        /// </summary>
        internal static string ConnectionStringUnknownParameter {
            get {
                return ResourceManager.GetString("ConnectionStringUnknownParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate connection ID..
        /// </summary>
        internal static string DuplicateConnectionId {
            get {
                return ResourceManager.GetString("DuplicateConnectionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation cannot be performed because the entity has been closed or aborted..
        /// </summary>
        internal static string EntityClosedOrAborted {
            get {
                return ResourceManager.GetString("EntityClosedOrAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entity path/name &apos;{0}&apos; exceeds the {1} character limit..
        /// </summary>
        internal static string EntityNameLengthExceedsLimit {
            get {
                return ResourceManager.GetString("EntityNameLengthExceedsLimit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This &apos;{0}&apos; instance has already been started once. To start another instance, please create a new &apos;{0}&apos; object and start that..
        /// </summary>
        internal static string InstanceAlreadyRunning {
            get {
                return ResourceManager.GetString("InstanceAlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Uri address given contains a path which is not allowed. Remove the path from the supplied Uri &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidAddressPath {
            get {
                return ResourceManager.GetString("InvalidAddressPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified Async result object is null or invalid..
        /// </summary>
        internal static string InvalidAsyncResult {
            get {
                return ResourceManager.GetString("InvalidAsyncResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection String is invalid {0}..
        /// </summary>
        internal static string InvalidConnectionString {
            get {
                return ResourceManager.GetString("InvalidConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string has an invalid encoding format..
        /// </summary>
        internal static string InvalidEncoding {
            get {
                return ResourceManager.GetString("InvalidEncoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entity name or path cannot contain &apos;/&apos; as prefix or suffix. The supplied value is &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidEntityNameFormatWithSlash {
            get {
                return ResourceManager.GetString("InvalidEntityNameFormatWithSlash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided URI scheme &apos;{0}&apos; is invalid; expected &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidUriScheme {
            get {
                return ResourceManager.GetString("InvalidUriScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Management port matches the current one..
        /// </summary>
        internal static string ManagementPortMatchesCurrent {
            get {
                return ResourceManager.GetString("ManagementPortMatchesCurrent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Management server is not running..
        /// </summary>
        internal static string ManagementServerNotRunning {
            get {
                return ResourceManager.GetString("ManagementServerNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The status code must be between 100 and 999 inclusive..
        /// </summary>
        internal static string net_InvalidStatus {
            get {
                return ResourceManager.GetString("net_InvalidStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception in {0}::{1} - {2}..
        /// </summary>
        internal static string net_log_exception {
            get {
                return ResourceManager.GetString("net_log_exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested security protocol is not supported..
        /// </summary>
        internal static string net_securityprotocolnotsupported {
            get {
                return ResourceManager.GetString("net_securityprotocolnotsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is not supported for a relative URI..
        /// </summary>
        internal static string net_uri_NotAbsolute {
            get {
                return ResourceManager.GetString("net_uri_NotAbsolute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified value has invalid Control characters..
        /// </summary>
        internal static string net_WebHeaderInvalidControlChars {
            get {
                return ResourceManager.GetString("net_WebHeaderInvalidControlChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket request or response operation was called with unsupported protocol(s)..
        /// </summary>
        internal static string net_WebSockets_AcceptUnsupportedProtocol {
            get {
                return ResourceManager.GetString("net_WebSockets_AcceptUnsupportedProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is already one outstanding &apos;{0}&apos; call for this WebSocket instance. ReceiveAsync and SendAsync can be called simultaneously, but at most one outstanding operation for each of them is allowed at the same time..
        /// </summary>
        internal static string net_Websockets_AlreadyOneOutstandingOperation {
            get {
                return ResourceManager.GetString("net_Websockets_AlreadyOneOutstandingOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket has already been started..
        /// </summary>
        internal static string net_WebSockets_AlreadyStarted {
            get {
                return ResourceManager.GetString("net_WebSockets_AlreadyStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message type &apos;{0}&apos; is not allowed for the &apos;{1}&apos; operation. Valid message types are: &apos;{2}, {3}&apos;. To close the WebSocket, use the &apos;{4}&apos; operation instead..
        /// </summary>
        internal static string net_WebSockets_Argument_InvalidMessageType {
            get {
                return ResourceManager.GetString("net_WebSockets_Argument_InvalidMessageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The byte array must have a length of at least &apos;{0}&apos; bytes..
        /// </summary>
        internal static string net_WebSockets_ArgumentOutOfRange_InternalBuffer {
            get {
                return ResourceManager.GetString("net_WebSockets_ArgumentOutOfRange_InternalBuffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &apos;{0}&apos; parameter ({1}) must be less than or equal to {2}..
        /// </summary>
        internal static string net_WebSockets_ArgumentOutOfRange_TooBig {
            get {
                return ResourceManager.GetString("net_WebSockets_ArgumentOutOfRange_TooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument must be a value greater than {0}..
        /// </summary>
        internal static string net_WebSockets_ArgumentOutOfRange_TooSmall {
            get {
                return ResourceManager.GetString("net_WebSockets_ArgumentOutOfRange_TooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server returned status code &apos;{0}&apos; when status code &apos;101&apos; was expected..
        /// </summary>
        internal static string net_WebSockets_Connect101Expected {
            get {
                return ResourceManager.GetString("net_WebSockets_Connect101Expected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An internal WebSocket error occurred. Please see the innerException, if present, for more details..
        /// </summary>
        internal static string net_WebSockets_Generic {
            get {
                return ResourceManager.GetString("net_WebSockets_Generic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket protocol &apos;{0}&apos; is invalid because it contains the invalid character &apos;{1}&apos;..
        /// </summary>
        internal static string net_WebSockets_InvalidCharInProtocolString {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidCharInProtocolString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The close status code &apos;{0}&apos; is reserved for system use only and cannot be specified when calling this method..
        /// </summary>
        internal static string net_WebSockets_InvalidCloseStatusCode {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidCloseStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The close status description &apos;{0}&apos; is too long. The UTF8-representation of the status description must not be longer than {1} bytes..
        /// </summary>
        internal static string net_WebSockets_InvalidCloseStatusDescription {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidCloseStatusDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty string is not a valid subprotocol value. Please use \&quot;null\&quot; to specify no value..
        /// </summary>
        internal static string net_WebSockets_InvalidEmptySubProtocol {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidEmptySubProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket schemes must be registered with the HttpWebRequest class..
        /// </summary>
        internal static string net_WebSockets_InvalidRegistration {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidRegistration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; header value &apos;{1}&apos; is invalid..
        /// </summary>
        internal static string net_WebSockets_InvalidResponseHeader {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidResponseHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket is in an invalid state (&apos;{0}&apos;) for this operation. Valid states are: &apos;{1}&apos;.
        /// </summary>
        internal static string net_WebSockets_InvalidState {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; instance cannot be used for communication because it has been transitioned into the &apos;{1}&apos; state..
        /// </summary>
        internal static string net_WebSockets_InvalidState_ClosedOrAborted {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidState_ClosedOrAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate protocols are not allowed: &apos;{0}&apos;..
        /// </summary>
        internal static string net_WebSockets_NoDuplicateProtocol {
            get {
                return ResourceManager.GetString("net_WebSockets_NoDuplicateProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket is not connected..
        /// </summary>
        internal static string net_WebSockets_NotConnected {
            get {
                return ResourceManager.GetString("net_WebSockets_NotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The close status description &apos;{0}&apos; is invalid. When using close status code &apos;{1}&apos; the description must be null..
        /// </summary>
        internal static string net_WebSockets_ReasonNotNull {
            get {
                return ResourceManager.GetString("net_WebSockets_ReasonNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only Uris starting with &apos;ws://&apos; or &apos;wss://&apos; are supported..
        /// </summary>
        internal static string net_WebSockets_Scheme {
            get {
                return ResourceManager.GetString("net_WebSockets_Scheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket protocol is not supported on this platform..
        /// </summary>
        internal static string net_WebSockets_UnsupportedPlatform {
            get {
                return ResourceManager.GetString("net_WebSockets_UnsupportedPlatform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to the remote server.
        /// </summary>
        internal static string net_webstatus_ConnectFailure {
            get {
                return ResourceManager.GetString("net_webstatus_ConnectFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Absolute Uri..
        /// </summary>
        internal static string NotValidAbsoluteUri {
            get {
                return ResourceManager.GetString("NotValidAbsoluteUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid TimeSpan..
        /// </summary>
        internal static string NotValidTimeSpan {
            get {
                return ResourceManager.GetString("NotValidTimeSpan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation cannot be performed because the object has been closed or aborted..
        /// </summary>
        internal static string ObjectClosedOrAborted {
            get {
                return ResourceManager.GetString("ObjectClosedOrAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object is read-only and cannot be modified..
        /// </summary>
        internal static string ObjectIsReadOnly {
            get {
                return ResourceManager.GetString("ObjectIsReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object is not in an open state..
        /// </summary>
        internal static string ObjectNotOpened {
            get {
                return ResourceManager.GetString("ObjectNotOpened", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request has timed out after {0} milliseconds. The successful completion of the request cannot be determined. Additional queries should be made to determine whether or not the operation has succeeded. For more information on exception types and proper exception handling, please refer to http://go.microsoft.com/fwlink/?LinkId=761101.
        /// </summary>
        internal static string RequestTimedOut {
            get {
                return ResourceManager.GetString("RequestTimedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be specified along with {1}. {0} alone should be sufficient to Authenticate the request..
        /// </summary>
        internal static string SasTokenShouldBeAlone {
            get {
                return ResourceManager.GetString("SasTokenShouldBeAlone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} must be a non-negative timeout value. The provided value was {1}..
        /// </summary>
        internal static string TimeoutMustBeNonNegative {
            get {
                return ResourceManager.GetString("TimeoutMustBeNonNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} must be a positive timeout value. The provided value was {1}..
        /// </summary>
        internal static string TimeoutMustBePositive {
            get {
                return ResourceManager.GetString("TimeoutMustBePositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided token does not specify the &apos;Audience&apos; value..
        /// </summary>
        internal static string TokenMissingAudience {
            get {
                return ResourceManager.GetString("TokenMissingAudience", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided token does not specify the &apos;ExpiresOn&apos; value..
        /// </summary>
        internal static string TokenMissingExpiresOn {
            get {
                return ResourceManager.GetString("TokenMissingExpiresOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A TokenProvider is required to perform management operations.  If a connection string was provided it must include either SharedAccessSignature or both SharedAccessKeyName and SharedAccessKey..
        /// </summary>
        internal static string TokenProviderRequired {
            get {
                return ResourceManager.GetString("TokenProviderRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find configuration {0}..
        /// </summary>
        internal static string UnableToFindConfigEntry {
            get {
                return ResourceManager.GetString("UnableToFindConfigEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find Registry key {0}..
        /// </summary>
        internal static string UnableToFindRegistryKey {
            get {
                return ResourceManager.GetString("UnableToFindRegistryKey", resourceCulture);
            }
        }
    }
}
