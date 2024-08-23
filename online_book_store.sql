-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Aug 19, 2024 at 09:47 AM
-- Server version: 8.3.0
-- PHP Version: 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `online_book_store`
--

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

DROP TABLE IF EXISTS `book`;
CREATE TABLE IF NOT EXISTS `book` (
  `BOOK_NAME` varchar(50) NOT NULL,
  `BOOK_AUTHOR` varchar(50) DEFAULT NULL,
  `BOOK_PRICE` varchar(50) DEFAULT NULL,
  `BOOK_IMG_NAME` varchar(50) DEFAULT NULL,
  `QTY` int NOT NULL,
  `CATEGORY` enum('Programming','Netwroking','Maths','Physics','Bio','English') NOT NULL,
  PRIMARY KEY (`BOOK_NAME`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`BOOK_NAME`, `BOOK_AUTHOR`, `BOOK_PRICE`, `BOOK_IMG_NAME`, `QTY`, `CATEGORY`) VALUES
('Think Like A Monk', 'Jay Shetty  ', 'Rs. 2690.00', '1.png', 23, 'English'),
('Rich Dad Poor Dad ', 'Robert T.Kiyosaki', 'Rs. 2,990.00', '2.png', 12, 'English'),
('The Subtle Art of Not Giving a F*ck', 'Mark Menson', 'Rs. 2,790.00', '3.png', 45, 'English'),
('The 5 AM Club', 'Robin Sharma', 'Rs. 1,990.00', '4.png', 10, 'English'),
('The Richest Man in Babylon', 'George S.Glason', 'Rs. 990.00', '5.png', 9, 'English'),
('Death', 'Sadhguru', 'Rs. 1,590.00', '6.png', 32, 'English');

-- --------------------------------------------------------

--
-- Table structure for table `worker`
--

DROP TABLE IF EXISTS `worker`;
CREATE TABLE IF NOT EXISTS `worker` (
  `STD_ID` varchar(20) NOT NULL,
  `NAME` varchar(50) DEFAULT NULL,
  `IMG` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`STD_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `worker`
--

INSERT INTO `worker` (`STD_ID`, `NAME`, `IMG`) VALUES
('MAHANAMA M.N.H.T.J.Y', 'STORE MANAGER', 'm1.jpg'),
('KOSHILA HANSANEE', 'ASSISTANT MANAGER', 'm2.jpg'),
('SHASHIKALA H.W.T.', 'SALES ASSOCIATE', 'm3.jpg'),
('SHAKITHTHIYAN P.', 'CASHIER', 'm4.jpg'),
('CHATHURANGA B.K', 'RECEIVING CLERK', 'm5.jpg'),
('RANSARA S.D.K ', 'MARKETING  SPECIALIST', 'm6.jpg');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
