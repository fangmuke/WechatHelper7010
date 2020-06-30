using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "VerifyVoicePrintRsaResponse")]
	[Serializable]
	public class VerifyVoicePrintRsaResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private VoicePieceCtx _NextPiece;

		private uint _Result;

		private uint _VoiceTicket;

		private string _AuthPwd = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "NextPiece", DataFormat = DataFormat.Default)]
		public VoicePieceCtx NextPiece
		{
			get
			{
				return this._NextPiece;
			}
			set
			{
				this._NextPiece = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public uint Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "VoiceTicket", DataFormat = DataFormat.TwosComplement)]
		public uint VoiceTicket
		{
			get
			{
				return this._VoiceTicket;
			}
			set
			{
				this._VoiceTicket = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "AuthPwd", DataFormat = DataFormat.Default), DefaultValue("")]
		public string AuthPwd
		{
			get
			{
				return this._AuthPwd;
			}
			set
			{
				this._AuthPwd = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
