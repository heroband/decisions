using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab10
{
    public class OrderFormMediator : IMediator
    {
        private DeliveryDateSelector deliveryDateSelector;
        private TimeSlotSelector timeSlotSelector;
        private Checkbox receiverCheckbox;
        private TextField receiverNameField;
        private TextField receiverPhoneField;
        private Checkbox pickupCheckbox;

        public OrderFormMediator(
            DeliveryDateSelector deliveryDateSelector,
            TimeSlotSelector timeSlotSelector,
            Checkbox receiverCheckbox,
            TextField receiverNameField,
            TextField receiverPhoneField,
            Checkbox pickupCheckbox)
        {
            this.deliveryDateSelector = deliveryDateSelector;
            this.timeSlotSelector = timeSlotSelector;
            this.receiverCheckbox = receiverCheckbox;
            this.receiverNameField = receiverNameField;
            this.receiverPhoneField = receiverPhoneField;
            this.pickupCheckbox = pickupCheckbox;


            this.deliveryDateSelector.setMediator(this);
            this.timeSlotSelector.setMediator(this);
            this.receiverCheckbox.setMediator(this);
            this.receiverNameField.setMediator(this);
            this.receiverPhoneField.setMediator(this);
            this.pickupCheckbox.setMediator(this);
        }

        public void Notify(Component sender, string eventCode)
        {
            if (sender == deliveryDateSelector && eventCode == "DateChanged")
            {
                UpdateAvailableTimeSlots();
            }
            else if (sender == receiverCheckbox && eventCode == "CheckedChanged")
            {
                ToggleReceiverFields();
            }
            else if (sender == pickupCheckbox && eventCode == "CheckedChanged")
            {
                ToggleDeliveryFields();
            }
        }

        private void UpdateAvailableTimeSlots()
        {
            Console.WriteLine("Посередник: оновлюю доступні проміжки часу відповідно до обраної дати.");
            timeSlotSelector.UpdateAvailableTimeSlots(new string[] { "10:00", "12:00", "14:00" });
        }

        private void ToggleReceiverFields()
        {
            if (receiverCheckbox.IsChecked())
            {
                Console.WriteLine("Посередник: 'Отримувач інша особа' вибрано. Відображаю поля 'Ім'я' та 'Телефон'");
                receiverNameField.SetEnabled(true);
                receiverPhoneField.SetEnabled(true);
            }
            else
            {
                Console.WriteLine("Посередник: 'Отримувач інша особа' не вибрано. Прибираю поля 'Ім'я' та 'Телефон'");
                receiverNameField.SetEnabled(false);
                receiverPhoneField.SetEnabled(false);
            }
        }

        private void ToggleDeliveryFields()
        {
            if (pickupCheckbox.IsChecked())
            {
                Console.WriteLine("Посередник: Обрано самовивіз. Прибираю елементи доставки.");
                deliveryDateSelector.SetEnabled(false);
                timeSlotSelector.SetEnabled(false);
                receiverCheckbox.SetEnabled(false);
                receiverNameField.SetEnabled(false);
                receiverPhoneField.SetEnabled(false);
            }
            else
            {
                Console.WriteLine("Посередник: Самовивіз не обрано. Відображаю елементи доставки.");
                deliveryDateSelector.SetEnabled(true);
                timeSlotSelector.SetEnabled(true);
                receiverCheckbox.SetEnabled(true);
            }
        }
    }
}