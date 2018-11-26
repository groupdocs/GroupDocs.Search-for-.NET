﻿using GroupDocs.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Search_for_.NET
{
    public class BusinessCases
    {
        /**
    * Creates a new books index, add documents in it and performs a search operation in it
    */
        public static void SearchBooks()
        {
            // Creating index folder
            Index index = new Index(Utilities.booksIndex);

            // Indexing documents in folder
            index.AddToIndex(Utilities.books);

            // When indexing is finished user can search in it
            SearchResults searchResults = index.Search("Gregor Samsa");

            // List of found files
            foreach (DocumentResultInfo result in searchResults)
            {
                Console.WriteLine((result.FileName));
            }
        }
        /**
         * Performs a search operation in existing books index
         */
        public static void SearchBooksInExistingIndex()
        {
            // Loading index
            Index index = new Index(Utilities.booksIndex);

            SearchResults searchResults = index.Search("Gregor Samsa");

            // List of found files
            foreach (DocumentResultInfo result in searchResults)
            {
                Console.WriteLine((result.FileName));
            }
        }
        /**
         * Adds documents in books index
         */
        public static void AddDocumentsInBooksIndex()
        {
            // Loading index
            Index index = new Index(Utilities.booksIndex);

            // Adding to index folder
            index.AddToIndex(Utilities.documentsPath);
        }
        /**
         * Updates books index
         */
        public static void UpdateBooksIndex()
        {
            // Loading index
            Index index = new Index(Utilities.booksIndex);

            // Updating index
            index.Update();

            SearchResults searchResults = index.Search("Gregor Samsa");

            // List of found files
            foreach (DocumentResultInfo result in searchResults)
            {
                Console.WriteLine((result.FileName));
            }
        }
        /**
         * Performs a search operation in several indexes using IndexRepository
         */
        public static void SearchInSeveralIndexes()
        {
            // Creating Index Repository
            IndexRepository repository = new IndexRepository();

            // Adding already created indexes fo repository
            repository.AddToRepository(Utilities.booksIndex);
            repository.AddToRepository(Utilities.indexPath);
            repository.AddToRepository(Utilities.indexPath2);

            // Searching in all indexes in repository
            SearchResults searchResults = repository.Search("Gregor Samsa");

            // List of found files
            foreach (DocumentResultInfo result in searchResults)
            {
                Console.WriteLine((result.FileName));
            }
        }
    }
}
