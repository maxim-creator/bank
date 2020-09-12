CREATE TABLE employee
(
  age INT NOT NULL,
  sex INT NOT NULL,
  name INT NOT NULL,
  code_of_employee INT NOT NULL,
  address INT NOT NULL,
  phone INT NOT NULL,
  passport_data INT NOT NULL,
  UNIQUE (phone),
  UNIQUE (passport_data)
);

CREATE TABLE position
(
  code_of_position INT NOT NULL,
  name_of_position INT NOT NULL,
  salary INT NOT NULL,
  duties INT NOT NULL,
  requirements INT NOT NULL,
  PRIMARY KEY (code_of_position),
  UNIQUE (name_of_position)
);

CREATE TABLE contribution
(
  code_of_contribution INT NOT NULL,
  name_of_contribution INT NOT NULL,
  min_time_of_deposit INT NOT NULL,
  max_time_of_deposit INT NOT NULL,
  interest_rate INT NOT NULL,
  additional_conditions INT NOT NULL,
  UNIQUE (name_of_contribution)
);

CREATE TABLE currency
(
  code_of_currency INT NOT NULL,
  name INT NOT NULL,
  exchange_rate INT NOT NULL,
  PRIMARY KEY (code_of_currency),
  UNIQUE (name)
);

CREATE TABLE depositor
(
  code_of_employee INT NOT NULL,
  passport_data INT NOT NULL,
  date_of_contribution INT NOT NULL,
  return_date INT NOT NULL,
  code_of_contribution INT NOT NULL,
  deposit_amount INT NOT NULL,
  amount_of_the_refund INT NOT NULL,
  mark_the_return_of_the_Depositbute INT NOT NULL,
  name INT NOT NULL,
  address INT NOT NULL,
  phone INT NOT NULL
);