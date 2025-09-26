-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26/09/2025 às 05:09
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `aereo_db`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `aeronaves`
--

CREATE TABLE `aeronaves` (
  `id_aeronave` int(10) NOT NULL,
  `matricula_aeronave` varchar(40) NOT NULL,
  `frota_aeronave` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `aeronaves`
--

INSERT INTO `aeronaves` (`id_aeronave`, `matricula_aeronave`, `frota_aeronave`) VALUES
(1, 'PR-OHG', 'S76'),
(2, 'PR-OHA', 'H155'),
(4, 'PR-OHB', 'AW189');

-- --------------------------------------------------------

--
-- Estrutura para tabela `manutencao`
--

CREATE TABLE `manutencao` (
  `id_task` int(10) NOT NULL,
  `aeronave` varchar(10) NOT NULL,
  `descricao_task` varchar(300) NOT NULL,
  `ATA` varchar(2) NOT NULL,
  `part_on` varchar(40) NOT NULL,
  `sn_on` varchar(40) NOT NULL,
  `part_off` varchar(40) NOT NULL,
  `sn_off` varchar(40) NOT NULL,
  `data` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `manutencao`
--

INSERT INTO `manutencao` (`id_task`, `aeronave`, `descricao_task`, `ATA`, `part_on`, `sn_on`, `part_off`, `sn_off`, `data`) VALUES
(1, '', 'Remove unserviceable fuel pump and install a serviceable unit in accordance with AMM 73-21-00.', '', '025323-500', 'FP-007912', '025323-500', 'FP-004587', ''),
(2, '', '| Check structural integrity and lubrication\n| of the right wing flap tracks. Report any\n| signs of corrosion or excessive wear.', '27', 'n/a', 'n/a', 'n/a', 'n/a', '09/27/2025'),
(3, '', '| Perform replacement of the left main landing\n| gear (LMLG) hydraulic actuator as per\n| maintenance manual Rev. 4.', '32', 'AXD-88102', 'BCF-95077', 'HG-2088-A1', 'AXD-88102', '09/26/2025'),
(4, 'PR-GTD', '| Realizar a substituição do atuador hidráulico\n| do trem de pouso principal esquerdo (LGM)\n| conforme manual de manutenção Rev. 4.', '32', 'HG-2088-A2', 'BCF-95077', 'HG-2088-A1', 'AXD-88102', '26/09/2025');

-- --------------------------------------------------------

--
-- Estrutura para tabela `partes`
--

CREATE TABLE `partes` (
  `id_parte` int(10) NOT NULL,
  `descricao_parte` varchar(40) NOT NULL,
  `part_number` varchar(40) NOT NULL,
  `serial_number` varchar(40) NOT NULL,
  `condition` varchar(30) NOT NULL DEFAULT 'NEW'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `partes`
--

INSERT INTO `partes` (`id_parte`, `descricao_parte`, `part_number`, `serial_number`, `condition`) VALUES
(1, 'Tail Rotor Blade', '3G62A200T211', '123', 'New'),
(2, 'Bearing', '8G64A200104', '22', 'New');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `aeronaves`
--
ALTER TABLE `aeronaves`
  ADD PRIMARY KEY (`id_aeronave`);

--
-- Índices de tabela `manutencao`
--
ALTER TABLE `manutencao`
  ADD PRIMARY KEY (`id_task`);

--
-- Índices de tabela `partes`
--
ALTER TABLE `partes`
  ADD PRIMARY KEY (`id_parte`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `aeronaves`
--
ALTER TABLE `aeronaves`
  MODIFY `id_aeronave` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `manutencao`
--
ALTER TABLE `manutencao`
  MODIFY `id_task` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `partes`
--
ALTER TABLE `partes`
  MODIFY `id_parte` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
