--
-- Table structure for table `passager`
--

CREATE TABLE IF NOT EXISTS `passager` (
  `codePassager` int(8) NOT NULL AUTO_INCREMENT,
  `nom` varchar(25) NOT NULL,
  `prenom` varchar(25) NOT NULL,
  `adresse` varchar(100) DEFAULT NULL,
  `telephone` varchar(20) DEFAULT NULL,
  `ville` varchar(25) DEFAULT NULL,
  `pays` varchar(25) DEFAULT NULL,
  `statut` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`codePassager`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `passager`
--

INSERT INTO `passager` (`codePassager`, `nom`, `prenom`, `adresse`, `telephone`, `ville`, `pays`, `statut`) VALUES
(1, 'Vill', 'Dav', '10343 ranco', NULL, 'Montreal', 'Canada', 'occasionnel'),
(2, 'Vil', 'Dav', '1343 Rancourt', NULL, 'Montreal', 'Canada', 'occasionnel'),
(3, '', '', '', NULL, '', '', ''),
(4, 'Vill', 'Dav', '1245', '4358550171', 'Mont', 'Can', 'Frequen Flyer'),
(5, 'khlkjh', 'lkjgg', 'luyjb', 'lkyiulh', 'lkjhuyfg', 'jbuygfuy', 'Frequen Flyer'),
(6, 'dav', 'fsfd', 'fgdvc', 'gfdgfc', 'hgdgfc', 'hgfdkjhg', 'Frequent Flyer'),
(7, 'jhg', 'kjhg', 'jhbj', 'kjhg', 'jkhb', 'jkhb', 'Frequent Flyer'),
(8, 'uh j', 'jk bjgh', 'jkh bjk ', 'lkjh j n', 'lkjh hjb', 'lkjh jkh', 'Frequent Flyer'),
(9, 'h kjln ', 'klj kljh', 'kj kljh ', 'kjh kjh ', 'kjh kjlh', 'kjh kljh ', 'Frequent Flyer'),
(10, 'jkhg jh', 'jhjb ', 'jh jh', 'jhlkjh', 'khgkjg', 'kjhg lkjh', 'Frequent Flyer'),
(11, 'jhghj', 'hgh', 'jkhg', 'jkhgjh', 'jhbjhg', 'jhgjhg', 'occasionnel'),
(12, 'dav', 'vill', 'jhjklhnj', 'jkhgbg', 'jhtv yfg', 'jhg hg', 'occasionnel'),
(13, 'vill', 'dav', 'jg gyug', 'jh kljl954', 'mede', 'jtvgfgv', 'occasionnel'),
(14, 'Bec', 'Tat', 'prefontaine', '514-555-5555', 'Monteria', 'Colombie', 'Frequent Flyer'),
(15, 'Bec', 'Tatjkhjkhkh', 'kjhjkh', 'kljhkjh', 'kjlhkjh', 'kjhjkh', 'occasionnel'),
(16, 'Bente', 'Hafed', '246516', '3456456', '6mtl', 'can', 'Frequent Flyer');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE IF NOT EXISTS `reservation` (
  `codeReservation` int(8) NOT NULL AUTO_INCREMENT,
  `codePassager` int(8) NOT NULL,
  `statutReservation` varchar(20) DEFAULT NULL,
  `dateReservation` date DEFAULT NULL,
  PRIMARY KEY (`codeReservation`),
  KEY `codePassager_fk` (`codePassager`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=17 ;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`codeReservation`, `codePassager`, `statutReservation`, `dateReservation`) VALUES
(1, 1, 'OK', '2024-04-24'),
(3, 2, 'OK', NULL),
(4, 6, 'Standby', '2024-05-10'),
(5, 1, 'OK', '2024-04-23'),
(6, 1, 'OK', '2024-04-26'),
(7, 1, 'Standby', '2024-05-01'),
(8, 6, 'OK', '2024-05-17'),
(9, 6, 'OK', '2024-05-22'),
(10, 6, 'OK         ', '2024-04-17'),
(11, 6, 'Standby', '2024-04-16'),
(12, 6, 'OK         ', '2024-04-26'),
(13, 6, 'Standby', '2024-04-27'),
(14, 6, 'OK         ', '2024-04-10'),
(15, 16, 'OK         ', '2024-04-16'),
(16, 16, 'Standby', '2024-04-18');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `codePassager_fk` FOREIGN KEY (`codePassager`) REFERENCES `passager` (`codePassager`);
