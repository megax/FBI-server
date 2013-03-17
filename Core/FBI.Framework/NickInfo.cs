/*
 * This file is part of FBI.
 * 
 * Copyright (C) 2010-2012 Megax <http://www.megaxx.info/>
 * 
 * FBI is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * FBI is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with FBI.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using FBI.Framework;
using FBI.Framework.Config;
using FBI.Framework.Localization;

namespace FBI.Irc
{
	public sealed class NickInfo
	{
		private readonly LocalizationConsole sLConsole = Singleton<LocalizationConsole>.Instance;
		private readonly IrcBase sIrcBase = Singleton<IrcBase>.Instance;
		private readonly Sender sSender;
		private string _NickStorage;
		private string _servername;
		private bool _Identify;
		private bool _Vhost;

		public string NickStorage
		{
			get { return _NickStorage; }
		}

		public bool IsNickStorage()
		{
			return _NickStorage.ToLower() == ServerList.List[_servername].NickName().ToLower();
		}

		public bool IsIdentify
		{
			get { return _Identify; }
		}

		public bool IsVhost
		{
			get { return _Vhost; }
		}

		public NickInfo(string ServerName)
		{
			_servername = ServerName;
			_Identify = false;
			_Vhost = false;
			sSender = sIrcBase.Networks[ServerName].sSender;
		}

		public string ChangeNick()
		{
			if(_NickStorage == ServerList.List[_servername].NickName())
			{
				_NickStorage = ServerList.List[_servername].NickName2();
				return _NickStorage;
			}
			else if(_NickStorage == ServerList.List[_servername].NickName2())
			{
				_NickStorage = ServerList.List[_servername].NickName3();
				return _NickStorage;
			}
			else if(_NickStorage == ServerList.List[_servername].NickName3())
			{
				_NickStorage = string.Format("_{0}_", ServerList.List[_servername].NickName());
				return _NickStorage;
			}
			else if(_NickStorage == string.Format("_{0}_", ServerList.List[_servername].NickName()))
			{
				_NickStorage = string.Format("__{0}_", ServerList.List[_servername].NickName());
				return _NickStorage;
			}
			else if(_NickStorage == string.Format("__{0}_", ServerList.List[_servername].NickName()))
			{
				_NickStorage = string.Format("__{0}__", ServerList.List[_servername].NickName());
				return _NickStorage;
			}
			else if(_NickStorage == string.Format("__{0}__", ServerList.List[_servername].NickName()))
			{
				_NickStorage = string.Format("___{0}", ServerList.List[_servername].NickName());
				return _NickStorage;
			}
			else if(_NickStorage == string.Format("___{0}", ServerList.List[_servername].NickName()))
			{
				_NickStorage = string.Format("___{0}_", ServerList.List[_servername].NickName());
				return _NickStorage;
			}
			else if(_NickStorage == string.Format("___{0}_", ServerList.List[_servername].NickName()))
			{
				_NickStorage = string.Format("___{0}__", ServerList.List[_servername].NickName());
				return _NickStorage;
			}
			else if(_NickStorage == string.Format("___{0}__", ServerList.List[_servername].NickName()))
			{
				_NickStorage = string.Format("___{0}___", ServerList.List[_servername].NickName());
				return _NickStorage;
			}
			else if(_NickStorage == string.Format("___{0}___", ServerList.List[_servername].NickName()))
			{
				_NickStorage = ServerList.List[_servername].NickName();
				return _NickStorage;
			}
			else
			{
				_NickStorage = ServerList.List[_servername].NickName();
				return _NickStorage;
			}
		}

		public void ChangeNick(string newnick)
		{
			_NickStorage = newnick;
		}

		public void Identify(string Password)
		{
			if(!_Identify)
			{
				Log.Notice("NickServ", sLConsole.NickServ("Text"));
				sSender.NickServ(Password);
			}
		}

		public void Vhost(string Status)
		{
			if(!_Vhost)
			{
				if(Status == FBIBase.Off)
				{
					_Vhost = true;
					Log.Notice("HostServ", sLConsole.HostServ("Text2"));
				}
				else if(Status == FBIBase.On)
					Log.Notice("HostServ", sLConsole.HostServ("Text"));

				sSender.HostServ(Status);
			}
		}

		public void ChangeIdentifyStatus(bool Status)
		{
			_Identify = Status;
		}

		public void ChangeVhostStatus(bool Status)
		{
			_Vhost = Status;
		}

		public string Parse(string Name)
		{
			if(Name.Length < 1)
				return string.Empty;

			switch(Name.Substring(0, 1))
			{
				case ":":
				case "~":
				case "&":
				case "@":
				case "%":
				case "+":
					return Name.Remove(0, 1);
				default:
					return Name;
			}
		}
	}
}