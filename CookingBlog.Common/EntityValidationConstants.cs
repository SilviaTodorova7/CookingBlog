namespace CookingBlog.Common
{
    public static class EntityValidationConstants
    {
        public static class Category
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;
        }

        public static class Comment
        {
            public const int TitleMinLength = 1;
            public const int TitleMaxLength = 50;

            public const int ContentMinLength = 1;
            public const int ContentMaxLength = 200;

        }

        public static class Rating
        {
            public const int RatingMinLength = 1;
            public const int RatingMaxLength = 5;
        }

        public static class Recipe
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 150;

            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 2000;

            public const int ImageUrlMinLength = 1;
            public const int ImageUrlMaxLength = 250;
        }
    }
}
