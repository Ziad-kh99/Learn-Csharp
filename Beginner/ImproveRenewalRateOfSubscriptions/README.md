# Challenge: Improve Renewal Rate of Subscriptions.

## Challenge Details:
- You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions 
  to the software. Your task is to display a renewal message when a user logs into the software system and is notified their subscription 
  will soon end. You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.

## Business Roles:
Rule 1: Your code should only display one message.
    - The message that your code displays will depend on the other five rules. For rules 2-6, the higher numbered rules take 
      precedence over the lower numbered rules.

Rule 2: If the user's subscription will expire in 10 days or less, display the message:
    `Your subscription will expire soon. Renew now!`

Rule 3: If the user's subscription will expire in five days or less, display the messages:
    `Your subscription expires in _ days.`
    `Renew now and save 10%!`

NOTE: Be sure to replace the _ character displayed in the message above with the value stored in the variable daysUntilExpiration 
      when you construct your message output.

Rule 4: If the user's subscription will expire in one day, display the messages:
    `Your subscription expires within a day!`
    `Renew now and save 20%!`

Rule 5: If the user's subscription has expired, display the message:
    `Your subscription has expired.`

Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.