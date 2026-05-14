-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 14, 2026 at 02:38 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `event_information_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `attendance_id` int(11) NOT NULL,
  `student_id` int(11) DEFAULT NULL,
  `event_id` int(11) DEFAULT NULL,
  `attendance_status` varchar(50) DEFAULT NULL,
  `attendance_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`attendance_id`, `student_id`, `event_id`, `attendance_status`, `attendance_date`) VALUES
(1, 5, 5, 'Present', '2026-05-13');

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `department_id` int(11) NOT NULL,
  `department_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`department_id`, `department_name`) VALUES
(1, 'Computer Science'),
(2, 'Information Technology'),
(3, 'Business'),
(4, 'Education'),
(5, 'Engineering'),
(6, 'Nursing'),
(7, 'Psychology'),
(8, 'Architecture'),
(9, 'Accountancy'),
(10, 'Medicine');

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

CREATE TABLE `events` (
  `event_id` int(11) NOT NULL,
  `event_name` varchar(100) DEFAULT NULL,
  `event_date` date DEFAULT NULL,
  `organizer_id` int(11) DEFAULT NULL,
  `venue` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `events`
--

INSERT INTO `events` (`event_id`, `event_name`, `event_date`, `organizer_id`, `venue`) VALUES
(1, 'Tech Seminar', '2025-01-10', 1, NULL),
(2, 'Startup Workshop', '2025-01-15', 2, NULL),
(3, 'Engineering Expo', '2025-02-01', 3, NULL),
(4, 'Health Awareness', '2025-09-17', 4, 'Tabaco City'),
(5, 'Coding Bootcamp', '2025-02-20', 5, NULL),
(6, 'Teaching Forum', '2025-03-01', 6, NULL),
(7, 'Mental Health Talk', '2025-03-10', 7, NULL),
(8, 'Design Exhibit', '2025-03-20', 8, NULL),
(9, 'Finance Summit', '2025-04-01', 9, NULL),
(10, 'Hotel Management Forum', '2025-04-10', 10, NULL),
(11, 'Code Walk', '2026-05-22', NULL, 'Legazpi City');

-- --------------------------------------------------------

--
-- Table structure for table `organizers`
--

CREATE TABLE `organizers` (
  `organizer_id` int(11) NOT NULL,
  `organizer_name` varchar(100) DEFAULT NULL,
  `contact_email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `organizers`
--

INSERT INTO `organizers` (`organizer_id`, `organizer_name`, `contact_email`) VALUES
(1, 'Tech Club', 'tech@email.com'),
(2, 'Business Society', 'biz@email.com'),
(3, 'Engineering Org', 'eng@email.com'),
(4, 'Health Group', 'health@email.com'),
(5, 'IT Circle', 'it@email.com'),
(6, 'Edu Society', 'edu@email.com'),
(7, 'Psych Assoc', 'psych@email.com'),
(8, 'Arch Group', 'arch@email.com'),
(9, 'Finance Club', 'finance@email.com'),
(10, 'Hospitality Org', 'hosp@email.com');

-- --------------------------------------------------------

--
-- Table structure for table `registrations`
--

CREATE TABLE `registrations` (
  `registration_id` int(11) NOT NULL,
  `student_id` int(11) DEFAULT NULL,
  `event_id` int(11) DEFAULT NULL,
  `registration_date` date DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registrations`
--

INSERT INTO `registrations` (`registration_id`, `student_id`, `event_id`, `registration_date`, `status`) VALUES
(1, 1, 1, '2024-12-20', 'Pending'),
(2, 2, 2, '2024-12-21', 'Confirmed'),
(3, 3, 3, '2024-12-22', 'Pending'),
(4, 4, 4, '2024-12-23', 'Confirmed'),
(5, 5, 5, '2024-12-24', 'Pending'),
(6, 6, 6, '2024-12-25', 'Confirmed'),
(7, 7, 7, '2024-12-26', 'Pending'),
(8, 8, 8, '2024-12-27', 'Confirmed'),
(9, 9, 9, '2024-12-28', 'Confirmed'),
(10, 10, 10, '2024-12-29', 'Pending'),
(13, 4, 1, '2026-05-12', 'Registered');

--
-- Triggers `registrations`
--
DELIMITER $$
CREATE TRIGGER `trg_delete` AFTER DELETE ON `registrations` FOR EACH ROW BEGIN
INSERT INTO registration_logs (student_id,event_id,action_type)
VALUES (OLD.student_id,OLD.event_id,'DELETE');
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trg_insert` AFTER INSERT ON `registrations` FOR EACH ROW BEGIN
INSERT INTO registration_logs (student_id,event_id,action_type)
VALUES (NEW.student_id,NEW.event_id,'INSERT');
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trg_update` AFTER UPDATE ON `registrations` FOR EACH ROW BEGIN
INSERT INTO registration_logs (student_id,event_id,action_type)
VALUES (NEW.student_id,NEW.event_id,'UPDATE');
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `registration_logs`
--

CREATE TABLE `registration_logs` (
  `log_id` int(11) NOT NULL,
  `student_id` int(11) DEFAULT NULL,
  `event_id` int(11) DEFAULT NULL,
  `action_type` varchar(20) DEFAULT NULL,
  `action_time` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registration_logs`
--

INSERT INTO `registration_logs` (`log_id`, `student_id`, `event_id`, `action_type`, `action_time`) VALUES
(1, 2, 1, 'INSERT', '2026-05-11 22:30:25'),
(2, 2, 1, 'INSERT', '2026-05-11 22:30:41'),
(3, 2, 1, 'DELETE', '2026-05-11 22:38:20'),
(4, 2, 1, 'DELETE', '2026-05-11 22:38:23'),
(5, 4, 1, 'INSERT', '2026-05-11 22:41:29');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(11) NOT NULL,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `department_id` int(11) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `first_name`, `last_name`, `email`, `department_id`, `password`, `status`) VALUES
(1, 'John', 'Doe', 'john1@email.com', 1, '12345678', 'Active'),
(2, 'Jane', 'Smith', 'jane2@email.com', 2, '1it31b1', 'Active'),
(3, 'Mark', 'Lee', 'mark3@email.com', 3, NULL, 'Active'),
(4, 'Anna', 'White', 'anna4@email.com', 4, NULL, 'Active'),
(5, 'Paul', 'Brown', 'paul5@email.com', 5, NULL, 'Active'),
(6, 'Liza', 'Green', 'liza6@email.com', 6, NULL, 'Active'),
(7, 'Tom', 'Hall', 'tom7@email.com', 7, NULL, 'Active'),
(8, 'Sara', 'Johnson', 'sara8@email.com', 8, NULL, 'Active'),
(9, 'Leo', 'Young', 'leo9@email.com', 9, NULL, 'Active'),
(10, 'Mia', 'Scott', 'mia10@email.com', 10, NULL, 'Active'),
(11, 'Alex', NULL, 'alex12@email.com', NULL, '', 'Inactive'),
(14, 'Trisha', 'Lopez', 'trilop11@email.com', 3, '', 'Inactive'),
(15, 'Luis', 'Anderson', 'LuAnd11@email.com', 6, '12345678', 'Active');

-- --------------------------------------------------------

--
-- Stand-in structure for view `view_student_event_report`
-- (See below for the actual view)
--
CREATE TABLE `view_student_event_report` (
`student_id` int(11)
,`student_name` varchar(101)
,`event_name` varchar(100)
,`status` varchar(50)
);

-- --------------------------------------------------------

--
-- Structure for view `view_student_event_report`
--
DROP TABLE IF EXISTS `view_student_event_report`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_student_event_report`  AS SELECT `s`.`student_id` AS `student_id`, concat(`s`.`first_name`,' ',`s`.`last_name`) AS `student_name`, `e`.`event_name` AS `event_name`, `r`.`status` AS `status` FROM ((`registrations` `r` join `students` `s` on(`r`.`student_id` = `s`.`student_id`)) join `events` `e` on(`r`.`event_id` = `e`.`event_id`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`attendance_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `event_id` (`event_id`);

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`department_id`);

--
-- Indexes for table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`event_id`),
  ADD KEY `organizer_id` (`organizer_id`);

--
-- Indexes for table `organizers`
--
ALTER TABLE `organizers`
  ADD PRIMARY KEY (`organizer_id`);

--
-- Indexes for table `registrations`
--
ALTER TABLE `registrations`
  ADD PRIMARY KEY (`registration_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `event_id` (`event_id`);

--
-- Indexes for table `registration_logs`
--
ALTER TABLE `registration_logs`
  ADD PRIMARY KEY (`log_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `department_id` (`department_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `attendance_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `departments`
--
ALTER TABLE `departments`
  MODIFY `department_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `events`
--
ALTER TABLE `events`
  MODIFY `event_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `organizers`
--
ALTER TABLE `organizers`
  MODIFY `organizer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `registrations`
--
ALTER TABLE `registrations`
  MODIFY `registration_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `registration_logs`
--
ALTER TABLE `registration_logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`),
  ADD CONSTRAINT `attendance_ibfk_2` FOREIGN KEY (`event_id`) REFERENCES `events` (`event_id`);

--
-- Constraints for table `events`
--
ALTER TABLE `events`
  ADD CONSTRAINT `events_ibfk_1` FOREIGN KEY (`organizer_id`) REFERENCES `organizers` (`organizer_id`);

--
-- Constraints for table `registrations`
--
ALTER TABLE `registrations`
  ADD CONSTRAINT `registrations_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`),
  ADD CONSTRAINT `registrations_ibfk_2` FOREIGN KEY (`event_id`) REFERENCES `events` (`event_id`);

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `departments` (`department_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
