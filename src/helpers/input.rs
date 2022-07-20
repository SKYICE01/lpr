use std::io::{self, Write};
pub fn string_input(prompt: &str) -> String {
    print!("{}", prompt);
    let mut input = String::new();
    let _ = io::stdout().flush();
    io::stdin()
        .read_line(&mut input)
        .expect("Error reading from STDIN");
    input.trim().to_string()
}

pub fn int_input(prompt: &str) -> usize {
    print!("{}", prompt);
    let mut input = String::new();
    let _ = io::stdout().flush();
    io::stdin()
        .read_line(&mut input)
        .expect("Error reading from STDIN");
    //try to parse the input as usize else return max usize
    match input.trim().parse::<usize>() {
        Ok(i) => i,
        Err(_) => {
            usize::max_value()
        }
    }
}

pub fn float_input(prompt: &str) -> f64 {
    print!("{}", prompt);
    let mut input = String::new();
    let _ = io::stdout().flush();
    io::stdin()
        .read_line(&mut input)
        .expect("Error reading from STDIN");
    //try to parse the input as f64 else return max f64
    let output = input.trim().parse::<f64>().unwrap();
    output
}
