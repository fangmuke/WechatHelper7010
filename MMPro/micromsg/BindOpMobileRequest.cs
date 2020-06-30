using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "BindOpMobileRequest")]
	[Serializable]
	public class BindOpMobileRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private string _UserName = "";

		private string _Mobile = "";

		private int _Opcode;

		private string _Verifycode = "";

		private int _DialFlag = 0;

		private string _DialLang = "";

		private string _AuthTicket = "";

		private uint _ForceReg = 0u;

		private string _SafeDeviceName = "";

		private string _SafeDeviceType = "";

		private SKBuiltinBuffer_t _RandomEncryKey = null;

		private string _Language = "";

		private uint _InputMobileRetrys = 0u;

		private uint _AdjustRet = 0u;

		private string _ClientSeqID = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
		public BaseRequest BaseRequest
		{
			get
			{
				return this._BaseRequest;
			}
			set
			{
				this._BaseRequest = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "UserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				this._UserName = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "Mobile", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				this._Mobile = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "Opcode", DataFormat = DataFormat.TwosComplement)]
		public int Opcode
		{
			get
			{
				return this._Opcode;
			}
			set
			{
				this._Opcode = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "Verifycode", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Verifycode
		{
			get
			{
				return this._Verifycode;
			}
			set
			{
				this._Verifycode = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "DialFlag", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int DialFlag
		{
			get
			{
				return this._DialFlag;
			}
			set
			{
				this._DialFlag = value;
			}
		}

		[ProtoMember(7, IsRequired = false, Name = "DialLang", DataFormat = DataFormat.Default), DefaultValue("")]
		public string DialLang
		{
			get
			{
				return this._DialLang;
			}
			set
			{
				this._DialLang = value;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "AuthTicket", DataFormat = DataFormat.Default), DefaultValue("")]
		public string AuthTicket
		{
			get
			{
				return this._AuthTicket;
			}
			set
			{
				this._AuthTicket = value;
			}
		}

		[ProtoMember(9, IsRequired = false, Name = "ForceReg", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint ForceReg
		{
			get
			{
				return this._ForceReg;
			}
			set
			{
				this._ForceReg = value;
			}
		}

		[ProtoMember(10, IsRequired = false, Name = "SafeDeviceName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string SafeDeviceName
		{
			get
			{
				return this._SafeDeviceName;
			}
			set
			{
				this._SafeDeviceName = value;
			}
		}

		[ProtoMember(11, IsRequired = false, Name = "SafeDeviceType", DataFormat = DataFormat.Default), DefaultValue("")]
		public string SafeDeviceType
		{
			get
			{
				return this._SafeDeviceType;
			}
			set
			{
				this._SafeDeviceType = value;
			}
		}

		[ProtoMember(12, IsRequired = false, Name = "RandomEncryKey", DataFormat = DataFormat.Default), DefaultValue(null)]
		public SKBuiltinBuffer_t RandomEncryKey
		{
			get
			{
				return this._RandomEncryKey;
			}
			set
			{
				this._RandomEncryKey = value;
			}
		}

		[ProtoMember(13, IsRequired = false, Name = "Language", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Language
		{
			get
			{
				return this._Language;
			}
			set
			{
				this._Language = value;
			}
		}

		[ProtoMember(14, IsRequired = false, Name = "InputMobileRetrys", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint InputMobileRetrys
		{
			get
			{
				return this._InputMobileRetrys;
			}
			set
			{
				this._InputMobileRetrys = value;
			}
		}

		[ProtoMember(15, IsRequired = false, Name = "AdjustRet", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint AdjustRet
		{
			get
			{
				return this._AdjustRet;
			}
			set
			{
				this._AdjustRet = value;
			}
		}

		[ProtoMember(16, IsRequired = false, Name = "ClientSeqID", DataFormat = DataFormat.Default), DefaultValue("")]
		public string ClientSeqID
		{
			get
			{
				return this._ClientSeqID;
			}
			set
			{
				this._ClientSeqID = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
