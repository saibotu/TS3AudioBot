// TS3AudioBot - An advanced Musicbot for Teamspeak 3
// Copyright (C) 2016  TS3AudioBot contributors
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace TS3AudioBot.Web
{
	using System;
	using System.Collections.Specialized;
	using System.Web;

	[Serializable]
	public class UriExt : Uri
	{
		private NameValueCollection queryParam = null;
		public NameValueCollection QueryParam => queryParam ?? (queryParam = HttpUtility.ParseQueryString(Query));
		public UriExt(Uri copy) : base(copy.OriginalString) { }
		public UriExt(string uri) : base(uri) { }
	}
}
