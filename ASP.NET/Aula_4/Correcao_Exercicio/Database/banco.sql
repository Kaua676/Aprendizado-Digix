DROP TABLE IF EXISTS software CASCADE;
DROP TABLE IF EXISTS maquina CASCADE;
DROP TABLE IF EXISTS usuarios CASCADE;

-- Tabela USUARIOS
CREATE TABLE usuarios (
    id_usuario    SERIAL        PRIMARY KEY,
    nome_usuario  VARCHAR(255)  NOT NULL,
    password      VARCHAR(255)  NOT NULL,
    ramal         INT           NOT NULL,
    especialidade VARCHAR(255)  NOT NULL
);

-- Tabela MAQUINA
CREATE TABLE maquina (
    id_maquina   SERIAL        PRIMARY KEY,
    tipo         VARCHAR(255)  NOT NULL,
    velocidade   INT           NOT NULL,
    harddisk     INT           NOT NULL,
    placa_rede   INT           NOT NULL,
    memoria_ram  INT           NOT NULL,
    fk_usuario   INT           NOT NULL,
    CONSTRAINT fk_maquina_usuario
        FOREIGN KEY (fk_usuario)
        REFERENCES usuarios (id_usuario)
);

-- Tabela SOFTWARE
CREATE TABLE software (
    id_software  SERIAL        PRIMARY KEY,
    produto      VARCHAR(255)  NOT NULL,
    harddisk     INT           NOT NULL,
    memoria_ram  INT           NOT NULL,
    fk_maquina   INT           NOT NULL,
    CONSTRAINT fk_software_maquina
        FOREIGN KEY (fk_maquina)
        REFERENCES maquina (id_maquina)
);
