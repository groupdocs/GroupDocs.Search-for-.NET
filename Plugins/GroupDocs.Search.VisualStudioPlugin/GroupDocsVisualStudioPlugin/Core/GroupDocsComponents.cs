﻿// Copyright (c) Aspose 2002-2016. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GroupDocsSearchVisualStudioPlugin.Core
{
    public class GroupDocsComponents
    {
        public static Dictionary<String, GroupDocsComponent> list = new Dictionary<string, GroupDocsComponent>();
        public GroupDocsComponents()
        {
            list.Clear();

            GroupDocsComponent GroupDocsSearch = new GroupDocsComponent();
            GroupDocsSearch.set_downloadUrl("");
            GroupDocsSearch.set_downloadFileName("groupdocs.search.zip");
            GroupDocsSearch.set_name(Constants.GROUPDOCS_COMPONENT);
            GroupDocsSearch.set_remoteExamplesRepository("https://github.com/groupdocs-search/GroupDocs.Search-for-.NET.git");
            list.Add(Constants.GROUPDOCS_COMPONENT, GroupDocsSearch);
        }
    }
}
