UPDATE [dbo].[Rented]
SET RentedDate = '2016-04-15',
    ReturnDate = '2016-04-25',
    ReturnCondition = 1,
    Notes = '$1,200 fine for dented vehicle.',
    TotalDays = 10,
    PaidDays = 1200 + (55 * 10)
WHERE RentedID = 1;

UPDATE [dbo].[Rented]
SET RentedDate = '2016-04-18',
    ReturnDate = '2016-04-25',
    ReturnCondition = 4,
    Notes = 'Vehicle returned in good condition.',
    TotalDays = 7,
    PaidDays = 55 * 7
WHERE RentedID = 2;

UPDATE [dbo].[Rented]
SET RentedDate = '2016-04-20',
    ReturnDate = '2016-04-25',
    ReturnCondition = 2,
    Notes = '$400 fine for scratched vehicle.',
    TotalDays = 5,
    PaidDays = 400 + (55 * 5)
WHERE RentedID = 3;

UPDATE [dbo].[Rented]
SET RentedDate = '2016-04-16',
    ReturnDate = '2016-04-25',
    ReturnCondition = 3,
    Notes = '$2.50/ga * 20 to fill gas tank.',
    TotalDays = 9,
    PaidDays = 9 * 55 + (2.50 * 20)
WHERE RentedID = 4;

UPDATE [dbo].[Rented]
SET RentedDate = '2016-04-19',
    ReturnDate = '2016-04-25',
    ReturnCondition = 4,
    Notes = 'Vehicle returned in good condition.',
    TotalDays = 6,
    PaidDays = 55 * 6
WHERE RentedID = 5;

UPDATE [dbo].[Rented]
SET RentedDate = '2016-04-16',
    ReturnDate = '2016-04-25',
    ReturnCondition = 3,
    Notes = '$2.50/ga * 20 to fill gas tank.',
    TotalDays = 9,
    PaidDays = 9 * 55 + (2.50 * 20)
WHERE RentedID = 6;


