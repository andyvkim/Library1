using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll();//gets all library assets

        LibraryAsset GetById(int id); //gets library asset by id

        void Add(LibraryAsset newAsset); // adds a new library asset

        string GetAuthorOrDirector(LibraryAsset id); //gets library asset by author or director

        string GetDeweyIndex(int id); //gets dewey index of library asset

        string GetType(int id); //gets type of library asset

        string GetTitle(int id);

        string GetIsbn(int id);

        LibraryBranch GetCurrentLocation(int id);
        string GetAuthorOrDirector(int id);
    }
}
